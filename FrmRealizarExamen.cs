using System.Diagnostics;
using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmRealizarExamen : Form
    {
        const string CARPETA = "files";
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");
        string rutaArchivoCorrecciones = Path.Combine(CARPETA, "Correcciones.json");
        bool bandera = false;

        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Examen> examenes = new List<Examen>();
        private List<Examen> correcciones = new List<Examen>();
        private List<Examen> examenesFiltrado = new List<Examen>();
        Examen examenAux = new Examen();

        //public string Carrera { get; set; }

        public FrmRealizarExamen(Examen examen)
        {
            InitializeComponent();
            CargarExamenes();
            CargarCorrecciones();
            examenAux = examen;
            lblFechaResolucion.Text = "";
            MostrarExamen(examen);
        }

        private void btnEntregarExamen_Click(object sender, EventArgs e)
        {

            // Cierra este formulario y cualquier modal anterior
            this.DialogResult = DialogResult.OK; // Opcional para indicar éxito
            GuardarResultados(examenAux);
            this.Close(); // Cierra el formulario actual
        }

        private void FrmRealizarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
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

        private void CargarExamenes()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoExamen);
                examenes = JsonSerializer.Deserialize<List<Examen>>(Json) ?? new List<Examen>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas.");
            }
        }

        private void CargarCorrecciones()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoCorrecciones);
                correcciones = JsonSerializer.Deserialize<List<Examen>>(Json) ?? new List<Examen>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correcciones está vacío.");
            }
        }

        private void GuardarResultados(Examen examen)
        {
            /*respuestasExamen.Add(examen.ExamenId.ToString());
            respuestasExamen.Add(examen.AlumnoNombre);
            respuestasExamen.Add(examen.AlumnoApellido);
            respuestasExamen.Add(examen.AlumnoDNI.ToString());*/

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    examen.Respuestas[0] = radioButton.TabIndex;
                }
            }

            foreach (Control control in groupBox2.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    examen.Respuestas[1] = radioButton.TabIndex;
                }
            }

            foreach (Control control in groupBox3.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    examen.Respuestas[2] = radioButton.TabIndex;
                }
            }

            foreach (Control control in groupBox4.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    examen.Respuestas[3] = radioButton.TabIndex;
                }
            }

            foreach (Control control in groupBox5.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    examen.Respuestas[4] = radioButton.TabIndex;
                }
            }


            examen.Calificacion = CorregirExamen(examen);

            examenes.Add(examen);

            correcciones.Add(examen);

            string json = JsonSerializer.Serialize(correcciones, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(rutaArchivoCorrecciones, json);
        }

        private float CorregirExamen(Examen examen)
        {
            float calificacion = 0;
            string[] respuestaCorrecta = new string[6];
            int[] indice = new int[6];

            for (int i = 0; i < examen.Preguntas.Count; i++)
            {
                indice[i] = examen.Preguntas[i].RespuestaCorrecta;
            }
           
            for (int i = 0; i < examen.Respuestas.Count; i++)
            {
                if (examen.Respuestas[i] == indice[i])
                {
                    calificacion += 2f;
                }
            }

            return calificacion;

        }
    }
}
