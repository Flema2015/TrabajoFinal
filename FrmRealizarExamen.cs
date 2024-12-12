using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmRealizarExamen : Form
    {
        const string CARPETA = "files";
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");
        string carreraAux, asignaturaAux;
        bool bandera = false;

        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Examen> examenes = new List<Examen>();
        private List<Examen> examenesFiltrado = new List<Examen>();

        //public string Carrera { get; set; }

        public FrmRealizarExamen(string carrera, string asignatura)
        {
            InitializeComponent();
            DateTime fecha = DateTime.Now.Date;
            carreraAux = carrera;
            asignaturaAux = asignatura;
            lblFechaResolucion.Text = fecha.ToShortDateString();
            lblCarreraCompletar.Text = carrera;

            CargarExamen();
        }

        private void btnEntregarExamen_Click(object sender, EventArgs e)
        {
            // Cierra este formulario y cualquier modal anterior
            this.DialogResult = DialogResult.OK; // Opcional para indicar éxito
            this.Close(); // Cierra el formulario actual
        }

        private void FrmRealizarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarExamen()
        {
            if (File.Exists(rutaArchivoExamen))
            {
                string jsonExamenes = File.ReadAllText(rutaArchivoExamen);
                examenes = JsonSerializer.Deserialize<List<Examen>>(jsonExamenes) ?? new List<Examen>();
            }

            try
            {
                var ExamenFiltradasPorCarrera = examenes
                   .Where(e => e.Carrera == carreraAux)
                    .ToList();

                var ExamenFiltradoPorAsignatura = ExamenFiltradasPorCarrera
                    .Where(e => e.Asignatura == asignaturaAux)
                    .ToList();

                examenesFiltrado = ExamenFiltradoPorAsignatura;

                int longitudListaExamen = examenesFiltrado.Count();
                
                if (longitudListaExamen <= 0)
                {
                    bandera = true;
                    MessageBox.Show("No hay exámenes cargados con la carrera elegida o asignaturas.");
                }
                else
                {
                    // Crear una instancia de la clase Random
                    Random random = new Random();

                    // Generar un número aleatorio entre 1 y longitud de la lista de examenes
                    int numeroAleatorio = random.Next(0, longitudListaExamen);
                    Examen examenesPrueba = examenes[numeroAleatorio];

                    MostrarExamen(examenesPrueba);

                    //Examen examenSeleccionado = ExamenFiltradoPorAsignatura[rand.Next(ExamenFiltradoPorAsignatura.Count )];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No hay exámenes cargados con la carrera elegida o asignaturas.");
            }
        }

        private void MostrarExamen(Examen examen)
        {
            // cargar los Labels.
            lblIDExamen.Text = "ID examen: " + examen.ExamenId.ToString();
            lblCarreraCompletar.Text = carreraAux;
            lblAsignaturaCompletar.Text = asignaturaAux;
            lblFechaResolucion.Text = examen.Fecha;

            //Grupo1 
            lblPregunta1.Text = examen.Preguntas[0].TxtPregunta;
            rdoRespuesta1Pregunta1.Text = examen.Preguntas[0].ListaDeRespuestas[0];
            rdoRespuesta2Pregunta1.Text = examen.Preguntas[0].ListaDeRespuestas[1];
            rdoRespuesta3Pregunta1.Text = examen.Preguntas[0].ListaDeRespuestas[2];
            rdoRespuesta4Pregunta1.Text = examen.Preguntas[0].ListaDeRespuestas[3];

            //grupo 2
            lblPregunta2.Text = examen.Preguntas[1].TxtPregunta;
            rdoRespuesta1Pregunta2.Text = examen.Preguntas[1].ListaDeRespuestas[0];
            rdoRespuesta2Pregunta2.Text = examen.Preguntas[1].ListaDeRespuestas[1];
            rdoRespuesta3Pregunta2.Text = examen.Preguntas[1].ListaDeRespuestas[2];
            rdoRespuesta4Pregunta2.Text = examen.Preguntas[1].ListaDeRespuestas[3];

            //grupo 3
            lblPregunta3.Text = examen.Preguntas[2].TxtPregunta;
            rdoRespuesta1Pregunta3.Text = examen.Preguntas[2].ListaDeRespuestas[0];
            rdoRespuesta2Pregunta3.Text = examen.Preguntas[2].ListaDeRespuestas[1];
            rdoRespuesta3Pregunta3.Text = examen.Preguntas[2].ListaDeRespuestas[2];
            rdoRespuesta4Pregunta3.Text = examen.Preguntas[2].ListaDeRespuestas[3];

            //grupo 4
            lblPregunta4.Text = examen.Preguntas[3].TxtPregunta;
            rdoRespuesta1Pregunta4.Text = examen.Preguntas[3].ListaDeRespuestas[0];
            rdoRespuesta2Pregunta4.Text = examen.Preguntas[3].ListaDeRespuestas[1];
            rdoRespuesta3Pregunta4.Text = examen.Preguntas[3].ListaDeRespuestas[2];
            rdoRespuesta4Pregunta4.Text = examen.Preguntas[3].ListaDeRespuestas[3];

            //grupo 5 
            lblPregunta5.Text = examen.Preguntas[4].TxtPregunta;
            rdoRespuesta1Pregunta5.Text = examen.Preguntas[4].ListaDeRespuestas[0];
            rdoRespuesta2Pregunta5.Text = examen.Preguntas[4].ListaDeRespuestas[1];
            rdoRespuesta3Pregunta5.Text = examen.Preguntas[4].ListaDeRespuestas[2];
            rdoRespuesta4Pregunta5.Text = examen.Preguntas[4].ListaDeRespuestas[3];
        }

        private void FrmRealizarExamen_Load(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                this.Close();
            }
        }
    }
}
