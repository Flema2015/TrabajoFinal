using System.Text.Json;
using System.Xml;

namespace TrabajoFinal_
{
    public partial class FrmModificarPregunta : Form
    {
        const int MAX = 4;
        const string CARPETA = "files";

        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");
        string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");

        Pregunta preguntaSeleccionada = new Pregunta();
        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Carrera> carreras = new List<Carrera>();
        private List<Asignatura> asignaturas = new List<Asignatura>();
        private List<string> respuestas = new List<string>();

        int i = 0;

        public FrmModificarPregunta()
        {
            InitializeComponent();
        }

        private void FrmModificarPregunta_Load(object sender, EventArgs e)
        {
            carreras = CargarCareras();
            if (carreras != null)
            {
                cmbCarrera.DataSource = carreras;
                cmbCarrera.DisplayMember = "Nombre";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarIDpregunta_Click(object sender, EventArgs e)
        {
            // Verificar si el ListBox tiene contenido
            if (lstPreguntas.Items.Count > 0)
            {
                // Borrar todo el contenido del ListBox
                lstPreguntas.Items.Clear();
            }

            string carrera = cmbCarrera.Text;
            string asignatura = cmbAsignatura.Text;

            string jsonPreguntas = File.ReadAllText(rutaArchivoPreguntas);
            preguntas = JsonSerializer.Deserialize<List<Pregunta>>(jsonPreguntas);

            try
            {
                var preguntasFiltradas = preguntas
                    .Where(p => p.Carrera == carrera && p.Asignatura == asignatura)
                    .ToList();

                lstPreguntas.DataSource = preguntasFiltradas;
                lstPreguntas.DisplayMember = "TxtPregunta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al busca Id!", ex.Message);
            }
        }

        private void btnModificarRespuesta_Click(object sender, EventArgs e)
        {
            /*{
                try
                {
                    // Validar que se haya seleccionado una respuesta en el ComboBox
                    int IndicieElegido = cmbRespuestas.SelectedIndex;
                    if (IndicieElegido == -1)
                    {
                        MessageBox.Show("selecciona una respuesta para modificar.");
                        return;
                    }

                    // Validar que se haya ingresado una nueva respuesta
                    string NuevaRespuesta = txtRespuesta.Text;
                    if (string.IsNullOrEmpty(NuevaRespuesta))
                    {
                        MessageBox.Show("ingresa una nueva respuesta.");
                        return;
                    }

                    // Leer el archivo JSON
                    string Json = File.ReadAllText(rutaArchivoPreguntas);
                    preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();

                    // Actualizar el ComboBox para reflejar los cambios
                    cmbRespuestas.Items[IndicieElegido] = NuevaRespuesta;

                    // Guardar los cambios en el archivo JSON
                    string nuevoJson = JsonSerializer.Serialize(preguntas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoPreguntas, nuevoJson);

                    MessageBox.Show("Datos guardados correctamente en el archivo JSON.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la respuesta.", ex.Message);
                }
            }*/
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

        private List<Carrera> CargarCareras()
        {
            string jsonCarreras = File.ReadAllText(rutaArchivoCarreras);
            var carreras = JsonSerializer.Deserialize<List<Carrera>>(jsonCarreras);

            return carreras;
        }

        private List<Asignatura> CargarAsignaturas()
        {
            string jsonAsignaturas = File.ReadAllText(rutaArchivoAsignaturas);
            var asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(jsonAsignaturas);

            return asignaturas;
        }

        private void lstPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que se haya seleccionado algún elemento.
            if (lstPreguntas.SelectedItem != null)
            {
                // Convierte el item seleccionado a la clase Pregunta.
                preguntaSeleccionada = lstPreguntas.SelectedItem as Pregunta;

                if (preguntaSeleccionada != null)
                {
                    // Asigna los valores de las propiedades a los TextBox.
                    txtPregunta.Text = preguntaSeleccionada.TxtPregunta;
                    txtCarrera.Text = preguntaSeleccionada.Carrera;
                    txtAsignatura.Text = preguntaSeleccionada.Asignatura;
                    txtUnidad.Text = preguntaSeleccionada.Unidad.ToString();
                    txtSubUnidad.Text = preguntaSeleccionada.SubUnidad.ToString();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPreguntaModificada = preguntaSeleccionada.PreguntaId; // O utiliza: preguntaSeleccionada.PreguntaId

                // Buscar la pregunta en la lista
                Pregunta preguntaAmodificar = preguntas.FirstOrDefault(p => p.PreguntaId == idPreguntaModificada);

                if (preguntaAmodificar != null)
                {
                    // Actualizar los datos de la pregunta con los nuevos valores de los controles.
                    preguntaAmodificar.TxtPregunta = txtPregunta.Text;
                    preguntaAmodificar.ListaDeRespuestas = respuestas;
                    preguntaAmodificar.RespuestaCorrecta = cmbRespuestas.SelectedIndex;
                    preguntaAmodificar.Carrera = txtCarrera.Text;
                    preguntaAmodificar.Asignatura = txtAsignatura.Text;
                    preguntaAmodificar.Unidad = int.Parse(txtUnidad.Text);
                    preguntaAmodificar.SubUnidad = int.Parse(txtSubUnidad.Text);

                    // Serializa la lista de preguntas al formato JSON
                    string json = JsonSerializer.Serialize(preguntas, new JsonSerializerOptions { WriteIndented = true });

                    // Escribe el JSON en el archivo
                    File.WriteAllText(rutaArchivoPreguntas, json);

                    MessageBox.Show("La pregunta se ha modificado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la pregunta a modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar la pregunta: " + ex.Message);
            }
        }
    }
}
