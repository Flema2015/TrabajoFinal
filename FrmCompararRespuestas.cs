using System.Text.Json;
using System.Linq;

namespace TrabajoFinal_
{
    public partial class FrmCompararRespuestas : Form
    {
        const string CARPETA = "files";

        string rutaArchivoCorrecciones = Path.Combine(CARPETA, "Correcciones.json");
        List<Correccion> correciones = new List<Correccion>();
        private List<Examen> correcciones = new List<Examen>();
        int DNIalumno;
        Correccion correccion = new Correccion();
        public FrmCompararRespuestas(int alumnoDNI)
        {
            InitializeComponent();
            DNIalumno = alumnoDNI;
            correciones = cargarCorreciones();
            correccion = cargarCorrecion(correciones,DNIalumno);
            cargarRespuestaUsuario();
            cargarRespuestaCorrectas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List <Correccion> cargarCorreciones()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoCorrecciones);
                var correciones = JsonSerializer.Deserialize<List<Correccion>>(Json);

                return correciones;


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
                string Json = File.ReadAllText(rutaArchivoCorrecciones);
                //var correciones = JsonSerializer.Deserialize<List<Correcion>>(Json);

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
            try
            {
                foreach (var respuesta in correciones)
                {
                    lstRespuestasUsuario.Items.Add(respuesta.Respuestas.ToString());
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
                for (int j = 0; j < index.Length; j++)
                {
                    //lstRespuestasCorrectas.Items.Add();
                }
                foreach (var respuesta in preguntas)
                {
                    lstRespuestasCorrectas.Items.Add(respuesta.RespuestaCorrecta.ToString());
                }
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show("hubo un problema al cargar las respuestas Correctas.");
            }
        }
    }
}
