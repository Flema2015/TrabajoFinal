using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmAdministrarCarrera : Form
    {
        private const string CARPETA = "files";

        private string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");

        private List<Carrera> carreras = new List<Carrera>();
        
        public FrmAdministrarCarrera()
        {
            InitializeComponent();
            CargarCarreras();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool verificacion = true;
            string nombre = txtNombre.Text;
            int duracion = int.Parse(txtDuracion.Text);
            string descripcion = txtDescripcion.Text;

            Carrera carrera = new Carrera();

            // Generar un ID automático e incremental
            int id = carreras.Any() ? carreras.Max(c => c.CarreraId) + 1 : 1;
            verificacion = validarCampos(nombre, duracion, descripcion);

            if (verificacion)
            {
                carrera.CarreraId = id;
                carrera.Nombre = nombre;
                carrera.Duracion = duracion;
                carrera.Descripcion = descripcion;

                // Mostrar un cuadro de diálogo para confirmar la acción
                DialogResult resultado = MessageBox.Show("¿Desea ingresar otra Carrera?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                carreras.Add(carrera);

                GuardarCarreras(carreras);

                if (resultado == DialogResult.Yes)
                {
                    txtNombre.Text = "";
                    txtDuracion.Text = "";
                    txtDescripcion.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdministrarCarrera_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorMenu.MostrarMenu();
        }

        private bool validarCampos(string nombre, int duracion, string descripcion)
        {
            if (nombre == "")
            {
                MessageBox.Show("Completar el campo Carrera.");
                return false;
            }

            if (duracion < 1)
            {
                MessageBox.Show("La carrera debe ser mayor a 1 año."); 
                return false;
            }

            if (descripcion == "")
            {
                MessageBox.Show("Completar el campo descripción de la carrera.");
                return false;
            }

            return true;
        }

        private void CargarCarreras()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoCarreras);
                carreras = JsonSerializer.Deserialize<List<Carrera>>(Json) ?? new List<Carrera>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las carreras.");
            }
        }

        private void GuardarCarreras(List<Carrera> carreras)
        {
            try
            {
                // Crea una lista para almacenar las asignaturas en formato JSON
                var listaCarrerasJSON = carreras.Select(carrera => new
                {
                    CarreraId = carrera.CarreraId,
                    Nombre = carrera.Nombre,
                    Duracion = carrera.Duracion,
                    Descripcion = carrera.Descripcion,
                }).ToList();

                // Serializa la lista de preguntas al formato JSON
                string json = JsonSerializer.Serialize(listaCarrerasJSON, new JsonSerializerOptions { WriteIndented = true });

                // Escribe el JSON en el archivo
                File.WriteAllText(rutaArchivoCarreras, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la Carrera.");
            }
        }
    }
}
