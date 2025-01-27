using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmModificarPregunta : Form
    {
        const string CARPETA = "files";

        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");
        string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");

        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Carrera> carreras = new List<Carrera>();
        private List<Asignatura> asignaturas = new List<Asignatura>();
        private List<string> respuestas = new List<string>();

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

        private void btnVolver_Click(object sender, EventArgs e)
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

                // Agregar al ListBox
                foreach (var pregunta in preguntasFiltradas)
                {
                    lstPreguntas.Items.Add($"ID: {pregunta.PreguntaId} - {pregunta.TxtPregunta}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al busca Id!", ex.Message);
            }
        }

        private void btnModificarRespuesta_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Validar que se haya seleccionado una respuesta en el ComboBox
                    int IndicieElegido = cmbNumeroRespuesta.SelectedIndex;
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
                    cmbNumeroRespuesta.Items[IndicieElegido] = NuevaRespuesta;

                    // Guardar los cambios en el archivo JSON
                    string nuevoJson = JsonSerializer.Serialize(preguntas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoPreguntas, nuevoJson);

                    MessageBox.Show("Datos guardados correctamente en el archivo JSON.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la respuesta.", ex.Message);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                var pregunta = preguntas.FirstOrDefault(p => p.PreguntaId.ToString() == txtIDPregunta.Text);
                if (pregunta == null)
                {
                    MessageBox.Show("No se encontró la pregunta con el ID proporcionado.");
                    return;
                }
                pregunta.TxtPregunta = txtPregunta.Text;
                pregunta.RespuestaCorrecta = int.Parse(txtRespuestaCorrecta.Text);
                //pregunta.Asignatura = txtAsignatura.Text;
                pregunta.Unidad = int.Parse(txtUnidad.Text);
                pregunta.SubUnidad = int.Parse(txtSubUnidad.Text);
                string Nuevojson = JsonSerializer.Serialize(preguntas, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivoPreguntas, Nuevojson);
                MessageBox.Show("Datos guardados correctamente en el archivo JSON.");
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar!", ex.Message);
            }
        }

        private List<Carrera> CargarCareras()
        {
            string jsonCarreras = File.ReadAllText(rutaArchivoCarreras);
            var carreras = JsonSerializer.Deserialize<List<Carrera>>(jsonCarreras);

            return carreras;
        }

        private void CargarBancoPreguntas()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoPreguntas);

                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();

                foreach (var pregunta in preguntas)
                {
                    /*
                    if (pregunta.PreguntaId.ToString() == txtIDPregunta.Text)
                    {
                        txtPregunta.Text = pregunta.TxtPregunta;
                        txtRespuestaCorrecta.Text = pregunta.RespuestaCorrecta.ToString();
                        //txtAsignatura.Text = pregunta.Asignatura;
                        txtUnidad.Text = pregunta.Unidad.ToString();
                        txtSubUnidad.Text = pregunta.SubUnidad.ToString();
                    }
                    */
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Json", ex.Message);
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

        private List<Asignatura> CargarAsignaturas()
        {
            string jsonAsignaturas = File.ReadAllText(rutaArchivoAsignaturas);
            var asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(jsonAsignaturas);

            return asignaturas;
        }

        private void lstPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay una selección
            if (lstPreguntas.SelectedIndex != -1)
            {
                // Obtener la pregunta seleccionada
                Pregunta preguntaSeleccionada = (Pregunta)lstPreguntas.SelectedItem;

                // Aquí puedes usar la pregunta completa
                MessageBox.Show($"ID: {preguntaSeleccionada.PreguntaId}\n" +
                                $"Texto: {preguntaSeleccionada.TxtPregunta}\n" +
                                $"Carrera: {preguntaSeleccionada.Carrera}\n" +
                                $"Asignatura: {preguntaSeleccionada.Asignatura}",
                                "Pregunta Seleccionada");
            }
        }
    }
}
