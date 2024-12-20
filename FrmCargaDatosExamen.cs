using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmCargaDatosExamen : Form
    {
        const string CARPETA = "files";

        string rutaArchivoAlumnos = Path.Combine(CARPETA, "Alumnos.json");
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");
        string rutaArchivoExamenes = Path.Combine(CARPETA, "Examenes.json");
        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");

        List<Carrera> carreras = new List<Carrera>();
        List<Asignatura> asignaturas = new List<Asignatura>();
        List<Pregunta> preguntas = new List<Pregunta>();
        List<Examen> examenes = new List<Examen>();

        public FrmCargaDatosExamen()
        {
            InitializeComponent();
        }

        private void FrmCargaDatosExamen_Load(object sender, EventArgs e)
        {
            carreras = CargarCareras();
            if (carreras != null)
            {
                cmbCarrera.DataSource = carreras;
                cmbCarrera.DisplayMember = "Nombre";
            }

            asignaturas = CargarAsignaturas();
            if (asignaturas != null)
            {
                var asignaturasConCarrera = asignaturas.Select(a => new
                {
                    NombreCompleto = $"{a.Nombre} - {a.Carrera.Nombre}",
                    Asignatura = a
                }).ToList();

                cmbAsignatura.DataSource = asignaturasConCarrera;
                cmbAsignatura.DisplayMember = "NombreCompleto";
                cmbAsignatura.ValueMember = "Asignatura";
            }
        }

        private void btnEmpezarExamen_Click(object sender, EventArgs e)
        {
            bool validacion = false;

            validacion = ValidarSeleccion();
            if (validacion)
            {
                Carrera carrera = cmbCarrera.SelectedItem as Carrera;
                cmbAsignatura.DataSource = asignaturas;
                Asignatura asignatura = cmbAsignatura.SelectedItem as Asignatura;
                Alumno alumno = new Alumno();

                DateTime fecha = DateTime.Now;
                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.Carrera = carrera;

                using (FrmRealizarExamen frmRealizarExamen = new FrmRealizarExamen(alumno, carrera, asignatura))
                {
                    frmRealizarExamen.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCargaDatosExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorMenu.MostrarMenu();
        }

        private bool ValidarSeleccion()
        {
            if (string.IsNullOrWhiteSpace(cmbCarrera.Text) || string.IsNullOrWhiteSpace(cmbAsignatura.Text))
            {
                MessageBox.Show("Selecciona una Carrera y una Asignatura.");
                return false;
            }
            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Completar nombre y apellido.");
                return false;
            }

            return true;
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
    }
}
