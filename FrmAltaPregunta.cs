using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmAltaPregunta : Form
    {
        const string CARPETA = "files";
        const int MAX = 4;

        int i = 0;
        int j = 0;
        int id = 0;

        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");
        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");

        List<Pregunta> preguntas = new List<Pregunta>();
        List<string> respuestas = new List<string>();

        public FrmAltaPregunta()
        {
            InitializeComponent();

            CargarPreguntas();
            // Busca el último ID y le suma 1
            id = preguntas.Any() ? preguntas.Max(c => c.PreguntaId) + 1 : 1;
            lblPreguntaID.Text = "Pregunta ID " + id.ToString();
            //CargarAsignaturas();
        }

        private void FrmAltaPregunta_Load(object sender, EventArgs e)
        {
            string jsonCarreras = File.ReadAllText(rutaArchivoCarreras);
            var carreras = JsonSerializer.Deserialize<List<Carrera>>(jsonCarreras);
            if (carreras != null)
            {
                cmbCarrera.DataSource = carreras;
                cmbCarrera.DisplayMember = "Name";
            }

            string jsonAsignaturas = File.ReadAllText(rutaArchivoAsignaturas);
            var asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(jsonAsignaturas);
            if (asignaturas != null)
            {
                var asignaturasConCarrera = asignaturas.Select(a => new
                {
                    NombreCompleto = $"{a.Nombre} - {a.Carrera.Nombre}",
                    Asignatura = a
                }).ToList();

                cmbAsignatura.DataSource = asignaturasConCarrera;
                cmbAsignatura.DisplayMember = "NombreCompleto";
                cmbAsignatura.ValueMember = "Asignatura";
            }
        }

        private void txtPregunta_MouseClick(object sender, MouseEventArgs e)
        {
            // Crear una instancia del formulario editor
            using (FrmEditorPregunta editor = new FrmEditorPregunta())
            {
                // Pasar el contenido actual del TextBox al editor
                editor.TextoInicial = txtPregunta.Text;

                // Mostrar el editor como un formulario modal
                var result = editor.ShowDialog();

                // Si el usuario presionó "Aceptar", transferir el texto
                if (result == DialogResult.OK)
                {
                    txtPregunta.Text = editor.TextoEscrito;
                }
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            bool verificacion = false;

            if (string.IsNullOrWhiteSpace(cmbAsignatura.Text) || string.IsNullOrWhiteSpace(cmbAsignatura.Text))
            {
                MessageBox.Show("Debes seleccionar una respuesta correcta o una asignatura.");
                return;
            }
            verificacion = validarCampos(txtPregunta.Text, txtUnidad.Text, txtSubUnidad.Text);

            Pregunta pregunta = new Pregunta();
            Carrera carrera = cmbCarrera.SelectedItem as Carrera;
            Asignatura asignatura = cmbAsignatura.SelectedItem as Asignatura;

            pregunta.PreguntaId = id;
            pregunta.TxtPregunta = txtPregunta.Text;
            pregunta.ListaDeRespuestas = respuestas;
            string respuesta = txtRespuesta.Text;
            pregunta.RespuestaCorrecta = cmbRespuestas.SelectedIndex;
            pregunta.Carrera = carrera;
            pregunta.Asignatura = asignatura;
            pregunta.Unidad = int.Parse(txtUnidad.Text);
            pregunta.SubUnidad = int.Parse(txtSubUnidad.Text);
            pregunta.Visible = true;

            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea ingresar otra pregunta antes de cerrar este formulario?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            preguntas.Add(pregunta);
            GuardarPregunta();

            // Si el usuario selecciona "si", permite ingresar otra pregunta.
            if (resultado == DialogResult.Yes)
            {
                // Borra el contenido de los campos.
                txtPregunta.Text = "";
                respuestas = new List<string>();
                txtRespuesta.Text = "";
                cmbAsignatura.SelectedIndex = -1;
                txtUnidad.Text = "";
                txtSubUnidad.Text = "";

                i = 0;
                lblRespuestas.Text = "Respuesta #" + (i + 1);

                cmbRespuestas.SelectedIndex = -1;
                cmbRespuestas.Items.Clear();

                id++;
                lblPreguntaID.Text = "Pregunta ID " + id.ToString();
            }
            else
            {
                this.Close();
            }
        }

        private void btnCargarRespuesta_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (txtRespuesta.Text == "")
            {
                error = true;
            }

            if (error)
            {
                alertaVacio.SetError(txtRespuesta, "Completar con una respuesta.");
                return;
            }
            else
            {
                alertaVacio.Clear();
            }

            // Da un maximo de respuestas.
            if (i < MAX)
            {
                lblRespuestas.Text = "Respuesta #" + (i + 1);

                respuestas.Add(txtRespuesta.Text);

                i++;
                cmbRespuestas.Items.Add(txtRespuesta.Text);
                txtRespuesta.Text = "";
            }
            else
            {
                txtRespuesta.Text = "";
                MessageBox.Show("Se ha cargado el máximo de respuestas.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCampos(string pregunta, string unidad, string subUnidad)
        {
            if (pregunta == "")
            {
                MessageBox.Show("completar el campo de pregunta");
                return false;
            }
            if (unidad == "")
            {
                MessageBox.Show("completar el campo de Unidad");
                return false;
            }
            if (subUnidad == "")
            {
                MessageBox.Show("completar el campo de SubUnidad");
                return false;
            }

            return true;
        }

        private void CargarPreguntas()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoPreguntas);
                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();

                if (preguntas == null || !preguntas.Any())
                {
                    lblPreguntaID.Text = "Pregunta ID    " + id.ToString();

                    // MessageBox.Show("No se encontraron preguntas.");
                    preguntas = new List<Pregunta>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las preguntas.");
            }
        }

        private void CargarAsignaturas()
        {
            try
            {
                /*
                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();
                foreach (Asignatura asignatura in asignaturas)
                {
                    cmbAsignaturas.Items.Add(asignatura.Nombre);
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas.");
            }
        }

        private void GuardarPregunta()
        {
            try
            {
                var listaPreguntasJson = preguntas.Select(pregunta => new
                {
                    PreguntaId = pregunta.PreguntaId,
                    TxtPregunta = pregunta.TxtPregunta,
                    ListaDeRespuestas = pregunta.ListaDeRespuestas,
                    RespuestaCorrecta = pregunta.RespuestaCorrecta,
                    Carrera = pregunta.Carrera,
                    Asignatura = pregunta.Asignatura,
                    Unidad = pregunta.Unidad,
                    SubUnidad = pregunta.SubUnidad,
                    Visible = pregunta.Visible
                }).ToList();

                // Serializa la lista de preguntas al formato JSON
                string json = JsonSerializer.Serialize(listaPreguntasJson, new JsonSerializerOptions { WriteIndented = true });

                // Escribe el JSON en el archivo
                File.WriteAllText(rutaArchivoPreguntas, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar las preguntas.");
            }
        }

        private void ObtenerIdPreguntaMaximo()
        {
            /*
            string rutaArchivoJson = Path.Combine(CARPETA, "Preguntas.json");

            int idFaltante = 0;
            try
            {
                // Verifica si el archivo existe
                if (!File.Exists(rutaArchivoJson))
                {
                    maxId += 1;
                    lblPreguntaID.Text = "Pregunta ID    " + maxId.ToString();

                    return;
                }

                // Lee el contenido del archivo JSON
                string contenidoJson = File.ReadAllText(rutaArchivoJson);

                // Deserializa el JSON en una lista de objetos
                List<Pregunta> preguntas = JsonSerializer.Deserialize<List<Pregunta>>(contenidoJson);

                var idsOrdenados = preguntas.Select(p => p.PreguntaId).ToList();

                if (preguntas == null || !preguntas.Any())
                {
                    maxId += 1;
                    lblPreguntaID.Text = "Pregunta ID    " + maxId.ToString();

                    return;
                }

                for (int j = 0; j < idsOrdenados.Count - 1; j++)
                {
                    if (idsOrdenados[j + 1] - idsOrdenados[j] > 1)
                    {
                        idFaltante = idsOrdenados[j] + 1;
                        lblPreguntaID.Text = "Pregunta ID    " + idFaltante.ToString();
                    }
                    else
                    {
                        // Obtiene el máximo PreguntaId
                        int idMax = preguntas.Max(p => (int)p.PreguntaId);

                        maxId = idMax + 1;

                        lblPreguntaID.Text = "Pregunta ID   " + maxId.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el máximo PreguntaId: " + ex.Message);
            }
            */
        }
    }
}
