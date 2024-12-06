using System.IO.Compression;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TrabajoFinal_
{
    public partial class FrmBajaPregunta : Form
    {
        const string CARPETA = "files";
        string rutaArchivo = Path.Combine(CARPETA, "Preguntas.json");

        private List<Pregunta> preguntas = new List<Pregunta>();

        public FrmBajaPregunta()
        {
            InitializeComponent();
            CargarBancoPreguntas();    
            cmbPreguntaABorrar.SelectedIndex = 0;
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

                if (string.IsNullOrEmpty(Json))
                {
                    preguntas = new List<Pregunta>();
                }
                else
                {
                    preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();
                }
               
                ActualizarLst();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar Json", ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbPreguntaABorrar.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar el elemento a eliminar");

                return;
            }
          
            int indiceElegido = cmbPreguntaABorrar.SelectedIndex;

            preguntas.RemoveAt(indiceElegido);

            cmbPreguntaABorrar.Text = "";

            GuardarCambiosEnArchivos();
            ActualizarLst();          
        }

        private void GuardarCambiosEnArchivos()
        {
            try
            {
                string JsonActualizado = JsonSerializer.Serialize(preguntas, new JsonSerializerOptions {WriteIndented = true });
                File.WriteAllText(rutaArchivo, JsonActualizado);
                MessageBox.Show("Se han guardado los cambios");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erorr al guardar ", ex.Message);
            }
        }

        private void ActualizarLst()
        {
            int i = 1;

            lstBaja.Items.Clear();

            foreach (var pregunta in preguntas)
            {
                lstBaja.Items.Add($"ID: {pregunta.PreguntaId}");

                lstBaja.Items.Add($"PREGUNTA: {pregunta.TxtPregunta}");
                foreach (var respuesta in pregunta.ListaDeRespuestas)
                {
                    lstBaja.Items.Add($"RESPUESTA {i}: {respuesta}");
                    i++;
                }
                i = 1;

                lstBaja.Items.Add($"RESPUESTA CORRECTA: {pregunta.RespuestaCorrecta}");

                lstBaja.Items.Add($"ASIGNATURA: {pregunta.Asignatura}");

                lstBaja.Items.Add($"UNIDAD : {pregunta.Unidad}");

                lstBaja.Items.Add($"SUBUNIDAD: {pregunta.SubUnidad}");

                lstBaja.Items.Add("---------------------");

                cmbPreguntaABorrar.Items.Add(pregunta.PreguntaId);
            }
        }
    }
}
