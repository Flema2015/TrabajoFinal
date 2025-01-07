using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmRealizarExamen : Form
    {
        const string CARPETA = "files";
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");
        string rutaArchivoRespuestas = Path.Combine(CARPETA, "Respuestas.json");
        bool bandera = false;

        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Examen> examenes = new List<Examen>();
        private List<Examen> examenesFiltrado = new List<Examen>();
        private List<String> respuestasExamen = new List<String>();

        //public string Carrera { get; set; }

        public FrmRealizarExamen(Examen examen)
        {
            InitializeComponent();
            lblFechaResolucion.Text = "";
            MostrarExamen(examen);
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

        private void MostrarExamen(Examen examen)
        {
            // cargar los Labels.
            lblIDExamen.Text = "ID examen: " + examen.ExamenId.ToString();
            lblCarreraCompletar.Text = examen.Carrera;
            lblAsignaturaCompletar.Text = examen.Asignatura;
            lblFechaResolucion.Text = examen.Fecha.ToString();

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

        private void GuardarResultados(Examen examen)
        {
            respuestasExamen.Add(examen.ExamenId.ToString());
            respuestasExamen.Add(examen.AlumnoNombre);
            respuestasExamen.Add(examen.AlumnoApellido);

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    respuestasExamen.Add((radioButton.TabIndex - 1).ToString());
                }
            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    respuestasExamen.Add((radioButton.TabIndex - 1).ToString());
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    respuestasExamen.Add((radioButton.TabIndex - 1).ToString());
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    respuestasExamen.Add((radioButton.TabIndex - 1).ToString());
                }
            }

            foreach (Control control in groupBox5.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    respuestasExamen.Add((radioButton.TabIndex - 1).ToString());
                }
            }

            string json = JsonSerializer.Serialize(respuestasExamen, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(rutaArchivoRespuestas, json);
        }

    }
}
