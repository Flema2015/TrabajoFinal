
namespace TrabajoFinal_
{
    class Correccion
    {
        public int ExamenId { get; set; }
        public int AlumnoDNI { get; set; }
        public string AlumnoNombre { get; set; }
        public string AlumnoApellido { get; set; }
        public DateTime Fecha { get; set; }
        public string Carrera { get; set; }
        public string Asignatura { get; set; }
        public List<Pregunta> Preguntas { get; set; }
        public float Calificacion { get; set; }
        public List<int> Respuestas { get; set; }

        // Constructor para inicializar listas
        public Correccion()
        {
            Preguntas = new List<Pregunta>(new Pregunta[6]);
            Respuestas = new List<int>(new int[5]);
        }
    }
}
