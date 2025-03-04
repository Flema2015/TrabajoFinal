﻿using System.Text.Json;

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
            examenes = CargarExamen();
            cmbUnidades.Items.Add("Unidades 1 - 3");
            cmbUnidades.Items.Add("Unidades 4 - 6");
        }

        private void FrmAdministrarExamen_Load(object sender, EventArgs e)
        {
            carreras = CargarCarreras();
            if (carreras != null)
            {
                cmbCarrera.DataSource = carreras;
                cmbCarrera.DisplayMember = "Nombre";
            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener Carrera seleccionada
            var carreraSeleccionada = cmbCarrera.SelectedItem as Carrera;

            asignaturas = CargarAsignaturas();
            if (carreraSeleccionada != null)
            {
                // Filtrar asignaturas según la CarreraId
                var asignaturasFiltradas = asignaturas
                    .Where(a => a.CarreraId == carreraSeleccionada.CarreraId)
                    .ToList();

                // Actualizar ComboBox de Asignaturas
                cmbAsignatura.DataSource = asignaturasFiltradas;
                cmbAsignatura.DisplayMember = "Nombre";
                cmbAsignatura.ValueMember = "AsignaturaId";
            }
        }

        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {

            string nombreCarrera = "", nombreAsignatura = "";
            bool verificación = false;

            verificación = ValidarSeleccion();
            if (verificación)
            {
                nombreCarrera = cmbCarrera.Text;
                nombreAsignatura = cmbAsignatura.Text;

                if (verificación)
                {
                    GenerarExamen(nombreCarrera, nombreAsignatura);
                }
            }
        }

        private void FrmAdministrarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mostrar el menú usando la clase estática
            GestorMenu.MostrarMenu();
        }

        private void btnVerUltimoExamen_Click(object sender, EventArgs e)
        {
            // abre el formulario 
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

        private void GenerarExamen(string nombreCarrera, string nombreAsignatura)
        {
            try
            {
                if (File.Exists(rutaArchivoExamenes))
                {
                    // Lee los exámenes existentes
                    string jsonExamenes = File.ReadAllText(rutaArchivoExamenes);
                }
                // Genera id de examen secuencial incremental
                id = examenes.Any() ? examenes.Max(c => c.ExamenId) + 1 : 1;

                preguntas = CargarPreguntas();
                // Filtrar preguntas por carrera seleccionada
                var preguntasFiltradasPorCarrera = preguntas
                     .Where(p => p.Carrera == nombreCarrera)
                     .ToList();

                // Filtrar preguntas por asignatura seleccionada
                var preguntasFiltradasPorAsignatura = preguntas
                     .Where(p => p.Asignatura == nombreAsignatura)
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
                    AlumnoDNI = 0,
                    AlumnoNombre = "",
                    AlumnoApellido = "",
                    Fecha = fechaActual,
                    Carrera = nombreCarrera,
                    Asignatura = nombreAsignatura,
                    Preguntas = preguntasPorSubunidad,
                    Calificacion = 0.0f,
                };

                // Agregar el examen a la lista
                examenes.Add(examen);

                // Guardar en el archivo JSON
                File.WriteAllText(rutaArchivoExamenes, JsonSerializer.Serialize(examenes));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el examen.");
            }
        }

        private List<Examen> CargarExamen()
        {
            string jsonExamenes = File.ReadAllText(rutaArchivoExamenes);
            var examenes = JsonSerializer.Deserialize<List<Examen>>(jsonExamenes);

            return examenes;
        }

        private List<Carrera> CargarCarreras()
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

        private List<Pregunta> CargarPreguntas()
        {
            string jsonPreguntas = File.ReadAllText(rutaArchivoPreguntas);
            var preguntas = JsonSerializer.Deserialize<List<Pregunta>>(jsonPreguntas);

            return preguntas;
        }
    }
}
