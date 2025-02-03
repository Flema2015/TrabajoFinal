using System.Text.Json;
using System.Linq;


namespace TrabajoFinal_
{
    public partial class FrmCorreccionEx : Form
    {
        const string CARPETA = "files";

        string rutaArchivoCorrecciones = Path.Combine(CARPETA, "Correcciones.json");
        List<Correccion> correciones = new List<Correccion>();
        private List<Examen> correcciones = new List<Examen>();
        public FrmCorreccionEx()
        {
            InitializeComponent();

        }
        private void btnVerDevolucion_Click(object sender, EventArgs e)
        {
            int DNIalumno = int .Parse(txtDniAlumno.Text);
            try
            {
                string Json = File.ReadAllText(rutaArchivoCorrecciones);
                var correciones = JsonSerializer.Deserialize<List<Correccion>>(Json);
                // Parsear el contenido como un objeto JObject

                if (true)
                {
                    FrmCompararRespuestas frmCompararRespuestas = new FrmCompararRespuestas(DNIalumno);
                    frmCompararRespuestas.ShowDialog();
                }
                else
                {
                    Console.WriteLine($"El DNI {txtDniAlumno} no existe en el archivo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correcciones está vacío.");
            }
        }

    

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCorreccionEx_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

       
    }
}
