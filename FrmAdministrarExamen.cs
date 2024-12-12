using System.Text.Json;
using System.Windows.Forms;

namespace TrabajoFinal_
{
    public partial class FrmAdministrarExamen : Form
    {
        const string CARPETA = "files";
        string rutaArchivoPreguntas = Path.Combine(CARPETA, "Preguntas.json");
        string rutaArchivoExamen = Path.Combine(CARPETA, "Examenes.json");
        string rutaArchivoAsignaturas = Path.Combine(CARPETA, "Asignaturas.json");
        
         List<Pregunta> preguntas = new List<Pregunta>();
         List<Examen> examenes = new List<Examen>();
         List<Asignatura> asignaturas = new List<Asignatura>();

        public FrmAdministrarExamen()
        {
            InitializeComponent();
            cargarJSON();
            /*cmbAsignatura.SelectedIndex = 0;
            cmbUnidades.SelectedIndex = 0;*/
            
            
        }


        private void btnIrAExamen_Click(object sender, EventArgs e)
        {
            
            validarSeleccion();
            crearExamen();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdministrarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

        private void cargarJSON()
        {
            try
            {
                string Json = File.ReadAllText(rutaArchivoAsignaturas);
                asignaturas = JsonSerializer.Deserialize<List<Asignatura>>(Json) ?? new List<Asignatura>();
                foreach (Asignatura asignatura in asignaturas)
                {
                    cmbAsignatura.Items.Add(asignatura.Nombre);
                }

                cmbUnidades.Items.Add("Unidades 1 - 3");
                cmbUnidades.Items.Add("Unidades 4 - 6");


            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las asignaturas");
            }



            /*try
            {
                string Json = File.ReadAllText(rutaArchivoPreguntas);
                preguntas = JsonSerializer.Deserialize<List<Pregunta>>(Json) ?? new List<Pregunta>();
                foreach (var pregunta in preguntas)
                {
                    cmbAsignatura.Items.Add(pregunta.Asignatura);
                }

                cmbUnidades.Items.Add("Unidades 1 - 3");
                cmbUnidades.Items.Add("Unidades 4 - 6");


            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar el json" + ex.Message);
            }*/

            

        }

        private void crearExamen()
        {
            try
            {
                // Leer exámenes existentes si el archivo ya está creado
                if (File.Exists(rutaArchivoExamen))
                {
                    string jsonExamenes = File.ReadAllText(rutaArchivoExamen);
                    examenes = JsonSerializer.Deserialize<List<Examen>>(jsonExamenes) ?? new List<Examen>();
                }

                // Filtrar preguntas por asignatura seleccionada
                var preguntasFiltradasPorAsignatura = preguntas
                    .Where(p => p.Asignatura == cmbAsignatura.Text)
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
                    .Where(p => int.TryParse(p.Unidad, out int unidad) && unidad >= unidadInicio && unidad <= unidadFin)
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
                Examen nuevoExamen = new Examen
                {
                    ExamenId = examenes.Count + 1,
                    Fecha = fechaActual.ToString("yyyy-MM-dd"),
                    Asignatura = cmbAsignatura.Text,
                    Preguntas = preguntasPorSubunidad,
                  
                };

                // Agregar el examen a la lista
                examenes.Add(nuevoExamen);

                // Guardar en el archivo JSON
                File.WriteAllText(rutaArchivoExamen, JsonSerializer.Serialize(examenes));

                MessageBox.Show("Examen creado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el examen: " + ex.Message);
            }
        }


        private void validarSeleccion()
        {
            if (string.IsNullOrWhiteSpace(cmbAsignatura.Text) || string.IsNullOrWhiteSpace(cmbUnidades.Text))
            {
                MessageBox.Show("Por favor, selecciona una asignatura y un rango de unidades.");
                return;
            }
        }

        private void btnVerUltimoExamen_Click(object sender, EventArgs e)
        {
            FrmExamenGenerado frmExamenGenerado = new FrmExamenGenerado();
            frmExamenGenerado.ShowDialog();
        }
    }
}
