namespace TrabajoFinal_
{
    public class Examen
    {
        public int ExamenId { get; set; }
        public int AlumnoDNI { get; set; }
        public string AlumnoNombre { get; set; }
        public string AlumnoApellido { get; set; }
        public DateTime Fecha {  get; set; }
        public string Carrera {  get; set; }
        public string Asignatura { get; set; }
        public List<Pregunta> Preguntas { get; set; }
        public float Calificacion { get; set; }

        // Constructor para inicializar listas
        public Examen()
        {
            Preguntas = new List<Pregunta>();
        }
    }
}
