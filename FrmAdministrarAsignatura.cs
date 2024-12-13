using System.Data;
using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmAdministrarAsignatura : Form
    {
        List<Asignatura> asignaturas = new List<Asignatura>();
//        List<Asignatura> lstBoxAsignaturas = new List<Asignatura>();

        const string CARPETA = "files";
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");

        private void CargarListaAsignaturas()
        {
            lstAsignaturas.Items.Clear();
            foreach (Asignatura asignatura in asignaturas)
            {
                lstAsignaturas.Items.Add("Carrera: " + asignatura.Carrera + " - Asignatura: " + asignatura.Nombre);
            }
        }

        private void CargarUnidades()
        {
            for (int i = 0; i < 10; i++)
            {
                cmbUnidades.Items.Add((i + 1).ToString());
            }
        }

        public FrmAdministrarAsignatura()
        {
            InitializeComponent();
            CargarAsignaturas();
            CargarListaAsignaturas();
            CargarUnidades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool verificacion = true;

            Asignatura asignatura = new Asignatura();

            verificacion = validarCampos(txtCarrera.Text, txtAsignatura.Text);
            if (string.IsNullOrWhiteSpace(cmbUnidades.Text))
            {
                MessageBox.Show("Seleccionar la cantidad de unidades que contiene la asignatura.");
                verificacion = false;
            }

            if (verificacion)
            {
                asignatura.Carrera = txtCarrera.Text;
                asignatura.Nombre = txtAsignatura.Text;

                string cantUnidades = cmbUnidades.Text;
                // Generar la lista de unidades desde 1 hasta el número seleccionado
                asignatura.Unidades = Enumerable.Range(1, int.Parse(cantUnidades)).ToList();

                // Mostrar un cuadro de diálogo para confirmar la acción
                DialogResult resultado = MessageBox.Show(
                "¿Desea ingresar otra Asignatura?",
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                asignaturas.Add(asignatura);
                GuardarAsignaturas(asignaturas);
                CargarListaAsignaturas();

                if (resultado == DialogResult.Yes)
                {
                    txtCarrera.Text = "";
                    txtAsignatura.Text = "";
                    cmbUnidades.SelectedIndex = -1;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void GuardarAsignaturas(List<Asignatura> asignaturas)
        {
            try
            {
                if (!Directory.Exists(CARPETA))
                {
                    Directory.CreateDirectory(CARPETA);
                    // Crea una lista para almacenar las asignaturas en formato JSON
                    var listaAsignaturasJSON = asignaturas.Select(asignatura => new
                    {
                        Carrera = asignatura.Carrera,
                        Nombre = asignatura.Nombre,
                        Unidades = asignatura.Unidades,
                    }).ToList();

                    // Serializa la lista de preguntas al formato JSON
                    string json = JsonSerializer.Serialize(listaAsignaturasJSON, new JsonSerializerOptions { WriteIndented = true });

                    // Escribe el JSON en el archivo
                    File.WriteAllText(rutaArchivoAsignaturas, json);
                }
                else
                {
                    string json = JsonSerializer.Serialize(asignaturas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaArchivoAsignaturas, json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos");
            }
        }

        private bool validarCampos(string carrera, string asignatura)
        {
            if (carrera == "")
            {
                MessageBox.Show("Completar el campo Carrera.");
                return false;
            }

            if (asignatura == "")
            {
                MessageBox.Show("Completar el campo de Asignatura.");
                return false;
            }

            return true;
        }

        private List<Asignatura> CargarAsignaturas()
        {
            try
            {
                // Verifica si existe la carpeta existe
                if (!Directory.Exists(CARPETA))
                {
                    return null;
                }

                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();

                return asignaturas;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("No se pudieron cargar las asignaturas.");
                return null;
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
    }
}
