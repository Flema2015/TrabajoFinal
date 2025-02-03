using System.Text.Json;
using System.Linq;
using System.Windows.Forms;

namespace TrabajoFinal_
{
    public partial class FrmCompararRespuestas : Form
    {
        const string CARPETA = "files";

        string rutaArchivoCorrecciones = Path.Combine(CARPETA, "Correcciones.json");
        List<Correccion> correcciones = new List<Correccion>();
        private List<Examen> examenes = new List<Examen>();
        int DNIalumno;
        Correccion correccion = new Correccion();
        public FrmCompararRespuestas(int alumnoDNI)
        {
            InitializeComponent();
            DNIalumno = alumnoDNI;
            correcciones = cargarCorrecciones();
            correccion = cargarCorrecion(correcciones,DNIalumno);
            cargarRespuestaUsuario();
            cargarRespuestaCorrectas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List <Correccion> cargarCorrecciones()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoCorrecciones);
                var correcciones = JsonSerializer.Deserialize<List<Correccion>>(Json);

                return correcciones;


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las correciones.");
                return null;
            }
        }
        private Correccion cargarCorrecion(List<Correccion> correciones, int dniBuscar)
        {
            try
            {
                
                var correccionEncontrada = correciones.FirstOrDefault(c => c.AlumnoDNI == dniBuscar);
                return correccionEncontrada;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las correciones.");
                return null;
            }
            
        }
        private void cargarRespuestaUsuario()
        {

            List<int> RespuestasUs = correccion.Respuestas;
            int[] respuestasUsArray = RespuestasUs.ToArray();
            try
            {
                lstRespuestasUsuario.Items.Clear();

                // Verificar que el tamaño del array y la lista de preguntas coincidan
                if (respuestasUsArray.Length != RespuestasUs.Count)
                {
                    MessageBox.Show("El número de índices no coincide con el número de preguntas.");
                    return;
                }

                // Iterar sobre los índices y preguntas
                for (int i = 0; i < respuestasUsArray.Length; i++)
                {
                    // Obtener el índice y la pregunta actual
                    int indice = respuestasUsArray[i];
                    var pregunta = correccion.Preguntas[i];

                    // Validar que el índice esté dentro del rango de la lista de respuestas
                    if (indice >= 0 && indice < pregunta.ListaDeRespuestas.Count)
                    {
                        // Obtener la respuesta correspondiente
                        string respuestaSeleccionada = pregunta.ListaDeRespuestas[indice];

                        // Agregar la pregunta y la respuesta seleccionada al ListBox
                        lstRespuestasUsuario.Items.Add($"{i+1}: {respuestaSeleccionada}");
                    }
                    else
                    {
                        // Manejar índices fuera de rango
                        lstRespuestasUsuario.Items.Add($"Respuesta Seleccionada: Índice fuera de rango");
                    }
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("hubo un problema al cargar las respuestas del usuario.");
            }
        }
        private void cargarRespuestaCorrectas()
        {
            List<Pregunta> preguntas = correccion.Preguntas;
            int[] index = new int[6];
            int i = 0;
            try
            {
                foreach (var indice in preguntas)
                {
                    index[i] = indice.RespuestaCorrecta;
                    i++;

                }
                
                lstRespuestasCorrectas.Items.Clear();

                // Verificar que el tamaño del array y la lista de preguntas coincidan
                if (index.Length != preguntas.Count)
                {
                    MessageBox.Show("El número de índices no coincide con el número de preguntas.");
                    return;
                }

                // Iterar sobre los índices y preguntas
                for (int j = 0; j < index.Length - 1; j++)
                {
                    // Obtener el índice y la pregunta actual
                    int indice = index[j];
                    var pregunta = correccion.Preguntas[j];

                    // Validar que el índice esté dentro del rango de la lista de respuestas
                    if (indice >= 0 && indice < pregunta.ListaDeRespuestas.Count)
                    {
                        // Obtener la respuesta correspondiente
                        string respuestaCorrecta = pregunta.ListaDeRespuestas[indice];

                        // Agregar la pregunta y la respuesta seleccionada al ListBox
                        lstRespuestasCorrectas.Items.Add($"{j+1}: {respuestaCorrecta}");
                    }
                    else
                    {
                        // Manejar índices fuera de rango
                        lstRespuestasCorrectas.Items.Add($"Respuesta Seleccionada: Índice fuera de rango");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("hubo un problema al cargar las respuestas Correctas.");
            }
        }
    }
}
