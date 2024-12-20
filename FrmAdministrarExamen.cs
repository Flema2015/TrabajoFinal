using System.Text.Json;

namespace TrabajoFinal_
{
    public partial class FrmAdministrarExamen : Form
    {
        const string CARPETA = "files";

        string rutaArchivoCarreras = Path.Combine(CARPETA, "Carreras.json");
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");
        string rutaArchivoExamenes = Path.Combine(CARPETA, "Examenes.json");

        int id = 0;

        List<Carrera> carreras = new List<Carrera>();
        List<Asignatura> asignaturas = new List<Asignatura>();
        List<Pregunta> preguntas = new List<Pregunta>();
        List<Examen> examenes = new List<Examen>();

        public FrmAdministrarExamen()
        {
            InitializeComponent();
            cmbUnidades.Items.Add("Unidades 1 - 3");
            cmbUnidades.Items.Add("Unidades 4 - 6");
        }

        private void FrmAdministrarExamen_Load(object sender, EventArgs e)
        {
            carreras = CargarCareras();
            if (carreras != null)
            {
                cmbCarrera.DataSource = carreras;
                cmbCarrera.DisplayMember = "Nombre";
            }

            asignaturas = CargarAsignaturas();
            if (asignaturas != null)
            {
                var asignaturasConCarrera = asignaturas.Select(a => new
                {
                    NombreCompleto = $"{a.Nombre} - {a.Carrera.Nombre}",
                    Asignatura = a
                }).ToList();

                cmbAsignatura.DataSource = asignaturasConCarrera;
                cmbAsignatura.DisplayMember = "NombreCompleto";
                cmbAsignatura.ValueMember = "Asignatura";
            }
        }

        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {
            bool verificación = false;
            verificación = ValidarSeleccion();
            if (verificación)
            {
                GenerarExamen();
            }
        }

        private void FrmAdministrarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

        private void btnVerUltimoExamen_Click(object sender, EventArgs e)
        {
            FrmExamenGenerado frmExamenGenerado = new FrmExamenGenerado();
            frmExamenGenerado.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarSeleccion()
        {
            if (string.IsNullOrWhiteSpace(cmbCarrera.Text) || string.IsNullOrWhiteSpace(cmbAsignatura.Text) || string.IsNullOrWhiteSpace(cmbUnidades.Text))
            {
                MessageBox.Show("Por favor, selecciona una Carrera, Asignatura y un rango de unidades.");
                return false;
            }

            return true;
        }

        private void GenerarExamen()
        {
            Carrera carrera = cmbCarrera.SelectedItem as Carrera;
            cmbAsignatura.DataSource = asignaturas;
            Asignatura asignatura = cmbAsignatura.SelectedItem as Asignatura;
            try
            {
                // Lee los exámenes existentes
                string jsonExamenes = File.ReadAllText(rutaArchivoExamenes);
                //examenes = JsonSerializer.Deserialize<List<Examen>>(jsonExamenes) ?? new List<Examen>();
                id = examenes.Any() ? examenes.Max(c => c.ExamenId) + 1 : 1;

                // Filtrar preguntas por asignatura seleccionada
                var preguntasFiltradasPorAsignatura = preguntas
                     .Where(p => p.Asignatura.Nombre == asignatura.Nombre)
                     .ToList();

                // Determinar las unidades según la selección del ComboBox
                int unidadInicio = 1, unidadFin = 3;
                if (cmbUnidades.Text.Contains("4 - 6"))
                {
                    unidadInicio = 4;
                    unidadFin = 6;
                }

                // Filtrar por el rango de unidades
                var preguntasFiltradasPorUnidades = preguntasFiltradasPorAsignatura
                    .Where(p => p.Unidad >= unidadInicio && p.Unidad <= unidadFin)
                    .ToList();

                // Agrupar por subunidad y seleccionar una pregunta aleatoria por cada subunidad
                var preguntasPorSubunidad = preguntasFiltradasPorUnidades
                    .GroupBy(p => new { p.Unidad, p.SubUnidad })
                    .Select(grupo =>
                    {
                        var preguntasDeSubunidad = grupo.ToList();
                        return preguntasDeSubunidad[new Random().Next(preguntasDeSubunidad.Count)]; // Selección aleatoria
                    })
                    .ToList();

                DateTime fechaActual = DateTime.Now;

                // Crear un nuevo examen
                Examen examen = new Examen
                {
                    ExamenId = id,
                    Fecha = fechaActual,
                    Carrera = carrera,
                    Asignatura = asignatura,
                };

                // Agregar el examen a la lista
                examenes.Add(examen);
                // Guardar en el archivo JSON
                File.WriteAllText(rutaArchivoExamenes, JsonSerializer.Serialize(examenes));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el examen.");
            }
        }

        private List<Carrera> CargarCareras()
        {
            string jsonCarreras = File.ReadAllText(rutaArchivoCarreras);
            var carreras = JsonSerializer.Deserialize<List<Carrera>>(jsonCarreras);

            return carreras;
        }

        private List<Asignatura> CargarAsignaturas()
        {
            string jsonAsignaturas = File.ReadAllText(rutaArchivoAsignaturas);
            var asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(jsonAsignaturas);

            return asignaturas;
        }

        /*
        private void CargarAsignaturas()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();

                foreach (Asignatura asignatura in asignaturas)
                {
                    cmbAsignatura.Items.Add(asignatura.Carrera + " - " + asignatura.Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas.");
            }
        }
        */
        
        /*
        private string SepararCarrera(string carrera)
        {
            string seleccion = cmbAsignatura.Text;

            // Separar el texto en base al guion "-"
            string[] partes = seleccion.Split('-');
            carrera = partes[0].Trim();

            return carrera;
        }

        private string SepararAsignatura(string asignatura)
        {
            string seleccion = cmbAsignatura.Text;

            // Separar el texto en base al guion "-"
            string[] partes = seleccion.Split('-');
            asignatura = partes[1].Trim();

            return asignatura;
        }*/
    }
}
