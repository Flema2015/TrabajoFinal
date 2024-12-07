using System.Text.Json;
using System.Windows.Forms;

namespace TrabajoFinal_
{
    public partial class FrmAdministrarExamen : Form
    {
        const string CARPETA = "files";
        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");
        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Examen> examenes = new List<Examen>();
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");

        public FrmAdministrarExamen()
        {
            InitializeComponent();           
            cargarJSON();
            cmbAsignatura.SelectedIndex = 0;
            cmbUnidades.SelectedIndex = 0;
        }


        private void btnIrAExamen_Click(object sender, EventArgs e)
        {
            FrmExamenGenerado frmExamenGenerado = new FrmExamenGenerado();
            frmExamenGenerado.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdministrarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

        private void cargarJSON()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoPreguntas);
                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();
                foreach (var pregunta in preguntas)
                {
                    cmbAsignatura.Items.Add(pregunta.Asignatura);
                }

                cmbUnidades.Items.Add("Unidades 1 - 3");
                cmbUnidades.Items.Add("unidades 4 - 6");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar el json" +  ex.Message);
            }

        }
    }
}
