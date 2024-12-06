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
                        txtAsignatura.Text = pregunta.Asignatura;
                        txtUnidad.Text = pregunta.Unidad;
                        txtSubUnidad.Text = pregunta.SubUnidad;
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
            try
            {
                int IndicieElegido = cmbNumeroRespuesta.SelectedIndex;

                string NuevaRespuesta = txtRespuesta.Text;

                string Json = File.ReadAllText(rutaArchivo);
                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();

                cmbNumeroRespuesta.Items[IndicieElegido] = NuevaRespuesta;
                MessageBox.Show("La respuesta se ha modificado Correctamente");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar!", ex.Message);
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                

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
