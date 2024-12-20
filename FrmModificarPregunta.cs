using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmModificarPregunta : Form
    {
        const string CARPETA = "files";
        string rutaArchivo = Path.Combine(CARPETA, "Preguntas.json");

        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<string> Respuestas = new List<string>();

        public FrmModificarPregunta()
        {
            InitializeComponent();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarBancoPreguntas()
        {
            try
            {

                string Json = File.ReadAllText(rutaArchivo);

                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();

                foreach (var pregunta in preguntas)
                {
                    if (pregunta.PreguntaId.ToString() == txtIDPregunta.Text)
                    {
                        txtPregunta.Text = pregunta.TxtPregunta;
                        txtRespuestaCorrecta.Text = pregunta.RespuestaCorrecta.ToString();
                        //txtAsignatura.Text = pregunta.Asignatura;
                        txtUnidad.Text = pregunta.Unidad.ToString();
                        txtSubUnidad.Text = pregunta.SubUnidad.ToString();
                        foreach (var Respuesta in pregunta.ListaDeRespuestas)
                        {
                            cmbNumeroRespuesta.Items.Add(Respuesta);
                        }

                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Json", ex.Message);
            }
        }

        private void btnBuscarIDpregunta_Click(object sender, EventArgs e)
        {
            try
            {
                CargarBancoPreguntas();
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
                    string Json = File.ReadAllText(rutaArchivo);
                    preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();

                    // Buscar la pregunta por el ID ingresado
                    var pregunta = preguntas.FirstOrDefault(p => p.PreguntaId.ToString() == txtIDPregunta.Text);

                    if (pregunta == null)
                    {
                        MessageBox.Show("No se encontró la pregunta con el ID proporcionado.");
                        return;
                    }

                    // Modificar la respuesta en la lista de respuestas de la pregunta
                    pregunta.ListaDeRespuestas[IndicieElegido] = NuevaRespuesta;

                    // Actualizar el ComboBox para reflejar los cambios
                    cmbNumeroRespuesta.Items[IndicieElegido] = NuevaRespuesta;

                    // Guardar los cambios en el archivo JSON
                    string nuevoJson = JsonSerializer.Serialize(preguntas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivo, nuevoJson);

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
                File.WriteAllText(rutaArchivo, Nuevojson);
                MessageBox.Show("Datos guardados correctamente en el archivo JSON.");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar!", ex.Message);
            }
        }
    }
}
