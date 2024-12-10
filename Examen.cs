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

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", ExamenId, Fecha, Asignatura, Preguntas);
        }

    }
}
