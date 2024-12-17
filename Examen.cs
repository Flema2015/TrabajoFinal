using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_
{
    internal class Examen
    {

        public int ExamenId { get; set; }
        public string Fecha {  get; set; }
        public string Asignatura { get; set; }
        public List<Pregunta> Preguntas { get; set; }

        public string NombreYApellido { get; set; }

        public List <string> idPregunta  { get; set;}
 
        public string Carrera {  get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", ExamenId, Fecha, Asignatura, Preguntas,NombreYApellido,Carrera);
        }

    }
}
