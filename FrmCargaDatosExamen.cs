using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmCargaDatosExamen : Form
    {
        const string CARPETA = "files";

        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");

        private List<Examen> examenes = new List<Examen>();
        List<Asignatura> asignaturas = new List<Asignatura>();

        public FrmCargaDatosExamen()
        {
            InitializeComponent();
            CargarCarreras();
            CargarAsignaturas();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool validacion = false;

            validacion = ValidarCampos(txtNombre.Text, txtApellido.Text);

            if (string.IsNullOrEmpty(cmbCarreras.Text) || string.IsNullOrEmpty(cmbAsignaturas.Text))
            {
                validacion = false;
            }
            
            if(validacion) {
                Alumno alumno = new Alumno();
                DateTime fecha = DateTime.Now;

                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                /*alumno.Carrera = cmbCarreras.Text;
                alumno.Asignatura = cmbAsignaturas.Text;
                alumno.Fecha = fecha.ToShortDateString();*/

                using (FrmRealizarExamen frmRealizarExamen = new FrmRealizarExamen(alumno))
                {
                    frmRealizarExamen.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCargaDatosExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorMenu.MostrarMenu();
        }

        private void CargarCarreras()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();

                // Extraer las carreras únicas
                var carrerasNoDuplicadas = asignaturas
                    .Select(asignatura => asignatura.Carrera) // Obtener solo las carreras
                    .Distinct() // Eliminar duplicados
                    .ToList();

                /*foreach (String carrera in carrerasNoDuplicadas)
                {
                    cmbCarreras.Items.Add(carrera);
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas.");
            }
        }

        private void CargarAsignaturas()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();

                // Extraer las asignaturas únicas
                var asignaturasNoDuplicadas = asignaturas
                    .Select(asignatura => asignatura.Nombre) // Obtener solo los nombres de las asignaturas
                    .Distinct() // Eliminar duplicados
                    .ToList();

                foreach (string asignatura in asignaturasNoDuplicadas)
                {
                    cmbAsignaturas.Items.Add(asignatura);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas.");
            }
        }

        private bool ValidarCampos(string nombre, string apellido)
        {
            if(nombre == "")
            {
                return false;
            }
            if (apellido == "")
            {
                return false;
            }

            return true;
        }
    }
}
