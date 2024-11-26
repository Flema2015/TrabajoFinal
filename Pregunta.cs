using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_
{
    public class Pregunta
    {
        string PreguntaId { get; set; }
        string TxtPregunta { get; set; }
        List <string> ListaDeRespuestas { get; set; }
        string RespuestaCorreta { get; set; }
        string Asignatura { get; set; }
        string Unidad { get; set; }
        string SubUnidad { get; set; }
        bool Visible { get; set; } 

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}",PreguntaId,TxtPregunta,ListaDeRespuestas,RespuestaCorreta,Asignatura,Unidad,SubUnidad);
        }
    }
    
}
