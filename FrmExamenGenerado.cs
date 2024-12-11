using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TrabajoFinal_
{
    public partial class FrmExamenGenerado : Form
    {
        const string CARPETA = "files";
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");
        private List<Examen> examenes = new List<Examen>();
        public FrmExamenGenerado()
        {
            InitializeComponent();
            cargarExamen();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarExamen()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoExamen);
                examenes = JsonSerializer.Deserialize<List<Examen>>(Json) ?? new List<Examen>();
                int i = 1;
                int j = 1;

                foreach (var examen in examenes)
                {
                    lstExamenGenerado.Items.Add($"ID: {examen.ExamenId}");

                    lstExamenGenerado.Items.Add($"FECHA: {examen.Fecha}");

                    lstExamenGenerado.Items.Add($"ASIGNATURA: {examen.Asignatura}");

                    lstExamenGenerado.Items.Add("-----------------------------------");

                    foreach (var preguntas in examen.Preguntas)
                    {
                        lstExamenGenerado.Items.Add($"PREGUNTA {i}: {preguntas.TxtPregunta}");
                        i++;
                        foreach (var respuestas in preguntas.ListaDeRespuestas)
                        {
                            lstExamenGenerado.Items.Add($"RESPUESTA {j}: {respuestas}");
                            j++;
                        }
                        j = 1;
                        lstExamenGenerado.Items.Add("-----------------------------------");
                    }
                    i = 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar Examen." + ex.Message);
            }
        }
    }
}
