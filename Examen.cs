namespace TrabajoFinal_
{
    public class Examen
    {
        public int ExamenId { get; set; }
        public DateTime Fecha {  get; set; }
        public Carrera Carrera {  get; set; }
        public Asignatura Asignatura { get; set; }
        public Alumno Alumno { get; set; }
        public List<Pregunta> Preguntas { get; set; }
        public float Calificacion { get; set; }

        // Constructor para inicializar listas
        public Examen()
        {
            Preguntas = new List<Pregunta>();
        }
    }
}
