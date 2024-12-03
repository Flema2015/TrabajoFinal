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
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarBancoPreguntas()
        {
            /*string rutaArchivo = Path.Combine(CARPETA, "Preguntas.json");
            int i = 1;
            //File.ReadAllText(rutaArchivo);
            string contenidoJson = File.ReadAllText(rutaArchivo);

            // Deserializa el JSON en una lista de preguntas
            var preguntas = JsonSerializer.Deserialize<List<Pregunta>>(contenidoJson);
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
            }

            MessageBox.Show("Datos cargados correctamente.");*/

            

            try
            {
                string Json = File.ReadAllText(rutaArchivo);
                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json);
                if (string.IsNullOrEmpty(Json))
                {
                    preguntas = new List<Pregunta>();
                }
                
                ActualizarLst();

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar Json", ex.Message);
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
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstBaja.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleciconar un elemento para eliminar.");
                return;
            }
          
            int indiceElegido = lstBaja.SelectedIndex;

            preguntas.RemoveAt(indiceElegido);

            GuardarCambiosEnArchivos();
            ActualizarLst();

            /*string contenidoJson = File.ReadAllText(rutaArchivo);
            var preguntas = JsonSerializer.Deserialize<List<Pregunta>>(contenidoJson);
            foreach (var pregunta in preguntas)
            {
                if (indiceActual == indiceElegido)
                {
                    preguntas.RemoveAt(indiceElegido);
                    GuardarCambiosEnArchivos();
                    CargarBancoPreguntas();
                    return;
                }
                indiceActual++;    
            }*/

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
    }
}
