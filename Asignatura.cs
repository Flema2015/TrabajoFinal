
namespace TrabajoFinal_
{
    public class Asignatura
    {
        public int AsignaturaId { get; set; }
        public string Nombre {  get; set; }
        public Carrera Carrera { get; set; }
        public List<int> Unidades { get; set; }
    }
}
