using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmMenuPrincipal : Form
    {
        const string CARPETA = "files";

        string rutaArchivoAlumnos = Path.Combine(CARPETA, "Alumnos.json");
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");
        string rutaArchivoExamenes = Path.Combine(CARPETA, "Examenes.json");
        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            InicializarArchivosJson();
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            // Ocultar el menú usando la clase estática
            GestorMenu.OcultarMenu();

            // Configurar el formulario hijo como hijo del MDI
            formularioHijo.MdiParent = this;
            //formularioHijo.FormClosed += FormularioHijo_FormClosed;
            formularioHijo.Show();
        }

        private void administrarPreguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrarPregunta frmAdministrarPreguntas = new FrmAdministrarPregunta();
            AbrirFormularioHijo(frmAdministrarPreguntas);
        }

        private void administrarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrarExamen frmAdministrarExamen = new FrmAdministrarExamen();
            AbrirFormularioHijo(frmAdministrarExamen);
        }
        private void realizarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargaDatosExamen frmCargaDatosExamen = new FrmCargaDatosExamen();
            AbrirFormularioHijo(frmCargaDatosExamen);
        }
        private void correcciónDeExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCorreccionEx frmCorreccionEx = new FrmCorreccionEx();
            AbrirFormularioHijo(frmCorreccionEx);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Asignar el menú principal a la clase estática
            GestorMenu.MenuPrincipal = menuStrip1;
        }

        private void administrarAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrarAsignatura frmAdministrarAsignatura = new FrmAdministrarAsignatura();
            AbrirFormularioHijo(frmAdministrarAsignatura);
        }

        private void administrarCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrarCarrera frmAdministrarCarrera = new FrmAdministrarCarrera();
            AbrirFormularioHijo(frmAdministrarCarrera);
        }

        private void InicializarArchivosJson()
        {
            try
            {
                if (!File.Exists(rutaArchivoAlumnos))
                {
                    string json = JsonSerializer.Serialize(rutaArchivoAlumnos, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoAlumnos, json);
                }
                if (!File.Exists(rutaArchivoAsignaturas))
                {
                    string json = JsonSerializer.Serialize(rutaArchivoAsignaturas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoAsignaturas, json);
                }
                if (!File.Exists(rutaArchivoCarreras))
                {
                    string json = JsonSerializer.Serialize(rutaArchivoCarreras, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoCarreras, json);
                }
                if (!File.Exists(rutaArchivoExamenes))
                {
                    string json = JsonSerializer.Serialize(rutaArchivoExamenes, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoExamenes, json);
                }
                if (!File.Exists(rutaArchivoPreguntas))
                {
                    string json = JsonSerializer.Serialize(rutaArchivoPreguntas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoPreguntas, json);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se puedieron crear los archivos.");
            }
        }
    }
}
