namespace TrabajoFinal_
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Carrera Carrera { get; set; }
        public List<Examen> Examenes { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
    }
}
