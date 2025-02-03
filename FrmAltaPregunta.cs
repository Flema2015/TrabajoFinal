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

        string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");

        List<Carrera> carreras = new List<Carrera>();
        List<Asignatura> asignaturas = new List<Asignatura>();
        List<Pregunta> preguntas = new List<Pregunta>();
        List<string> respuestas = new List<string>();

        public FrmAltaPregunta()
        {
            InitializeComponent();

            CargarPreguntas();
            // Busca el último ID y le suma 1
            id = preguntas.Any() ? preguntas.Max(c => c.PreguntaId) + 1 : 1;
            lblPreguntaID.Text = "Pregunta ID " + id.ToString();
            
        }

        private void FrmAltaPregunta_Load(object sender, EventArgs e)
        {
            carreras = CargarCareras();
            if (carreras != null)
            {
                cmbCarrera.DataSource = carreras;
                cmbCarrera.DisplayMember = "Nombre";
            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener Carrera seleccionada
            var carreraSeleccionada = cmbCarrera.SelectedItem as Carrera;

            asignaturas = CargarAsignaturas();
            if (carreraSeleccionada != null)
            {
                // Filtrar asignaturas según la CarreraId
                var asignaturasFiltradas = asignaturas
                    .Where(a => a.CarreraId == carreraSeleccionada.CarreraId)
                    .ToList();

                // Actualizar ComboBox de Asignaturas
                cmbAsignatura.DataSource = asignaturasFiltradas;
                cmbAsignatura.DisplayMember = "Nombre";
                cmbAsignatura.ValueMember = "AsignaturaId";
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

                // Si el usuario presionó aceptar, transferir el texto
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
            pregunta.Carrera = cmbCarrera.Text;
            pregunta.Asignatura = cmbAsignatura.Text;
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
                //alerta vacio = objeto de la clase errorProvider.
                //Aparece un ícono rojo al lado del TextBox si está vacío.
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

        private List<Carrera> CargarCareras()
        {
            string jsonCarreras = File.ReadAllText(rutaArchivoCarreras);
            var carreras = JsonSerializer.Deserialize<List<Carrera>>(jsonCarreras);

            return carreras;
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

        private List<Asignatura> CargarAsignaturas()
        {
            string jsonAsignaturas = File.ReadAllText(rutaArchivoAsignaturas);
            var asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(jsonAsignaturas);

            return asignaturas;
        }
    }
}
