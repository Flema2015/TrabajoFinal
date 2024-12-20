using System.Data;
using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmAdministrarAsignatura : Form
    {
        private const string CARPETA = "files";

        private string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        private string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");

        private List<Asignatura> asignaturas = new List<Asignatura>();
        private List<Carrera> carreras = new List<Carrera>();
        
        public FrmAdministrarAsignatura()
        {
            InitializeComponent();

            CargarAsignaturas();
            CargarListaAsignaturas();
            CargarCmbUnidades();
        }

        private void FrmAdministrarAsignatura_Load(object sender, EventArgs e)
        {
            string jsonCarreras = File.ReadAllText(rutaArchivoCarreras);
            var carreras = JsonSerializer.Deserialize<List<Carrera>>(jsonCarreras);

            if (carreras != null)
            {
                cmbCarreras.DataSource = carreras;
                cmbCarreras.DisplayMember = "Nombre"; // ID interno para referencia
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCarreras.Text))
            {
                MessageBox.Show("Seleccionar la cantidad de unidades que contiene la asignatura.");
                return;
            }

            bool verificacion = true;
            string nombre = txtNombre.Text;
            Carrera carrera = cmbCarreras.SelectedItem as Carrera;
            int unidades = 0;
            unidades = int.Parse(cmbUnidades.Text);

            Asignatura asignatura = new Asignatura();

            // Generar un ID automático e incremental
            int id = asignaturas.Any() ? asignaturas.Max(c => c.AsignaturaId) + 1 : 1;

            verificacion = validarCampos(nombre, unidades);

            if (verificacion)
            {
                asignatura.AsignaturaId = id;
                asignatura.Nombre = nombre;
                asignatura.Carrera = carrera;
                asignatura.Unidades = Enumerable.Range(1, unidades).ToList(); // Generar lista de unidades

                // Mostrar un cuadro de diálogo para confirmar la acción
                DialogResult resultado = MessageBox.Show("¿Desea ingresar otra Asignatura?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                asignaturas.Add(asignatura);
                GuardarAsignaturas(asignaturas);
                CargarListaAsignaturas();

                if (resultado == DialogResult.Yes)
                {
                    txtNombre.Text = "";
                    cmbCarreras.SelectedIndex = -1;
                    cmbUnidades.SelectedIndex = -1;
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

        private void FrmAdministrarAsignatura_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorMenu.MostrarMenu();
        }

        private void GuardarAsignaturas(List<Asignatura> asignaturas)
        {
            try
            {
                // Crea una lista para almacenar las asignaturas en formato JSON
                var listaAsignaturasJSON = asignaturas.Select(asignatura => new
                {
                    AsignaturaId = asignatura.AsignaturaId,
                    Nombre = asignatura.Nombre,
                    Carrera = asignatura.Carrera,
                    Unidades = asignatura.Unidades,
                }).ToList();

                // Serializa la lista de preguntas al formato JSON
                string json = JsonSerializer.Serialize(listaAsignaturasJSON, new JsonSerializerOptions { WriteIndented = true });

                // Escribe el JSON en el archivo
                File.WriteAllText(rutaArchivoAsignaturas, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pudo guardar la asignatura.");
            }
        }

        private bool validarCampos(string nombre, int unidades)
        {
            if (nombre == "")
            {
                MessageBox.Show("Completar con nombre de la Asignatura.");
                return false;
            }
            if (unidades < 1)
            {
                MessageBox.Show("Las unidades tienen que ser mayor a 0.");
                return false;
            }

            return true;
        }

        private void CargarAsignaturas()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas.");
            }
        }

        private void CargarListaAsignaturas()
        {
            foreach (Asignatura asignatura in asignaturas)
            {
                lstAsignaturas.Items.Add(asignatura.Nombre + " - " + asignatura.Carrera.Nombre);
            }
        }

        private void CargarCmbUnidades()
        {
            for (int i = 0; i < 10; i++)
            {
                cmbUnidades.Items.Add((i + 1).ToString());
            }
        }
    }
}
