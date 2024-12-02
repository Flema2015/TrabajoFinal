using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmAltaPregunta : Form
    {
        const string CARPETA = "files";
        const int MAX = 4;

        int i = 0;
        int maxId = 0;

        List<Pregunta> preguntas = new List<Pregunta>();
        List<string> respuestas = new List<string>();

        public FrmAltaPregunta()
        {
            InitializeComponent();

            ObtenerIdPreguntaMaximo();

            // TODO verifica el ultimo id en el archivo.
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Pregunta pregunta = new Pregunta();

            pregunta.PreguntaId = int.Parse(lblNumeroIdPregunta.Text);
            pregunta.TxtPregunta = txtPregunta.Text;
            pregunta.ListaDeRespuestas = respuestas;
            string respuesta = txtRespuesta.Text;
            pregunta.RespuestaCorrecta = txtRespuestaCorrecta.Text;
            pregunta.Asignatura = txtAsignatura.Text;
            pregunta.Unidad = txtUnidad.Text;
            pregunta.SubUnidad = txtSubUnidad.Text;
            pregunta.Visible = true;
            
            validarCampos(pregunta.TxtPregunta, respuesta, pregunta.RespuestaCorrecta, pregunta.Asignatura, pregunta.Unidad, pregunta.SubUnidad);

            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show(
            "¿Desea ingresar otra pregunta antes de cerrar este formulario?",
            "Confirmar cierre",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            preguntas.Add(pregunta);

            GuardarPregunta();

            // Si el usuario selecciona "si", permite ingresar otra pregunta.
            if (resultado == DialogResult.Yes)
            {
                // borra el contenido de los campos.
                lblNumeroIdPregunta.Text = "";
                txtPregunta.Text = "";
                respuestas = new List<string>();
                txtRespuesta.Text = "";
                txtRespuestaCorrecta.Text = "";
                txtAsignatura.Text = "";
                txtUnidad.Text = "";
                txtSubUnidad.Text = "";

                i = 0;
                lblRespuestas.Text = "Respuestas # " + (i + 1);
                cmbRespuestas.Items.Clear();

                maxId++;

                lblNumeroIdPregunta.Text = maxId.ToString();
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
                alertaVacio.SetError(txtRespuesta, "Completar con una respuesta");
                return;
            }
            else
            {
                alertaVacio.Clear();
            }

            // Da un maximo de respuestas.
            if (i < 4)
            {
                lblRespuestas.Text = "Respuestas # " + (i + 1);
                
                respuestas.Add(txtRespuesta.Text);
                i++;
                
                cmbRespuestas.Items.Add(txtRespuesta.Text);

            }
            else
            {
                MessageBox.Show("Se ha cargado el maximo de respuestas");
            }
        }

        private void validarCampos(string Pregunta, string respuesta, string RespuestaCorrecta, string Asignatura, string Unidad, string SubUnidad)
        {
            if (Pregunta == "")
            {
                MessageBox.Show("completar el campo de pregunta");
                return;
            }
            if (respuesta == "")
            {
                MessageBox.Show("completar el campo de respuesta ");
                return;

            }
            if (RespuestaCorrecta == "")
            {
                MessageBox.Show("completar el campo de Respuesta correcta");
                return;

            }
            if (Asignatura == "")
            {
                MessageBox.Show("completar el campo de Asignatura");
                return;
            }
            if (Unidad == "")
            {
                MessageBox.Show("completar el campo de Unidad");
                return;
            }
            if (SubUnidad == "")
            {
                MessageBox.Show("completar el campo de SubUnidad");
                return;
            }
        }

        private void ObtenerIdPreguntaMaximo()
        {
            string rutaArchivoJson = Path.Combine(CARPETA, "Preguntas.json");

            try
            {
                // Verifica si el archivo existe
                if (!File.Exists(rutaArchivoJson))
                {
                    maxId++;
                    lblNumeroIdPregunta.Text = maxId.ToString();

                    return;
                }

                // Lee el contenido del archivo JSON
                string contenidoJson = File.ReadAllText(rutaArchivoJson);

                // Deserializa el JSON en una lista de objetos
                var preguntas = JsonSerializer.Deserialize<List<Pregunta>>(contenidoJson);

                if (preguntas == null || !preguntas.Any())
                {
                    lblNumeroIdPregunta.Text = maxId.ToString();

                    return;
                }

                // Obtiene el máximo PreguntaId
                int idMax = preguntas.Max(p => (int)p.PreguntaId);

                maxId = idMax;

                lblNumeroIdPregunta.Text = (maxId + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el máximo PreguntaId: " + ex.Message);
            }
        }

        private void GuardarPregunta()
        {
            string rutaArchivo = Path.Combine(CARPETA, "Preguntas.json");

            try
            {
                // Verifica si la carpeta existe, si no, la crea
                if (!Directory.Exists(CARPETA))
                {
                    Directory.CreateDirectory(CARPETA);
                }

                // Crea una lista para almacenar las preguntas en formato JSON
                var listaPreguntasJson = preguntas.Select(pregunta => new
                {
                    PreguntaId = pregunta.PreguntaId,
                    TxtPregunta = pregunta.TxtPregunta,
                    ListaDeRespuestas = pregunta.ListaDeRespuestas,
                    RespuestaCorrecta = pregunta.RespuestaCorrecta,
                    Asignatura = pregunta.Asignatura,
                    Unidad = pregunta.Unidad,
                    SubUnidad = pregunta.SubUnidad,
                    Visible = pregunta.Visible
                }).ToList();

                // Serializa la lista de preguntas al formato JSON
                string json = JsonSerializer.Serialize(listaPreguntasJson, new JsonSerializerOptions { WriteIndented = true });

                // Escribe el JSON en el archivo
                File.WriteAllText(rutaArchivo, json);

                MessageBox.Show("Datos guardados correctamente en el archivo JSON.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }
    }
}
