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

        int idAleatorio = 0;

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
            carreras = CargarCarreras();
            if (carreras != null)
            {
                cmbCarrera.DataSource = carreras;
                cmbCarrera.DisplayMember = "Nombre";
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

        private void btnEmpezarExamen_Click(object sender, EventArgs e)
        {
            bool validacion = false;

            validacion = ValidarCampos();
            
            if (validacion)
            {
                
                examenes = CargarExamenes();
                // Obtener un ID aleatorio
                Random random = new Random();
                //se pasa carrera y asignatura, se desordena, se elige un id y toma el primer elemento.
                idAleatorio = examenes
                                .Where(e => e.Carrera == cmbCarrera.Text && e.Asignatura == cmbAsignatura.Text) // Filtrar
                                .OrderBy(x => random.Next()) // Desordenar aleatoriamente
                                .Select(e => e.ExamenId) // Seleccionar IDs
                                .FirstOrDefault(); // Tomar el primer elemento aleatorio

                // Obtener el examen completo con el ID aleatorio
                Examen examen = examenes.FirstOrDefault(e => e.ExamenId == idAleatorio);

                examen.AlumnoDNI = int.Parse(txtDni.Text);
                examen.AlumnoNombre = txtNombre.Text;
                examen.AlumnoApellido = txtApellido.Text;
                DateTime fecha = DateTime.Now;
                examen.Fecha = fecha;
                //abre el formulario realizar examen.
                using (FrmRealizarExamen frmRealizarExamen = new FrmRealizarExamen(examen))
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

        private bool ValidarCampos()
        {
            if (txtDni.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Completar DNI, nombre y apellido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmbCarrera.Text) || string.IsNullOrWhiteSpace(cmbAsignatura.Text))
            {
                MessageBox.Show("Selecciona una Carrera y una Asignatura.");
                return false;
            }

            return true;
        }

        private List<Examen> CargarExamenes()
        {
            string jsonExamenes = File.ReadAllText(rutaArchivoExamenes);
            var examenes = JsonSerializer.Deserialize<List<Examen>>(jsonExamenes);

            return examenes;
        }

        private List<Carrera> CargarCarreras()
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
