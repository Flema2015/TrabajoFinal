namespace TrabajoFinal_
{
    public class Pregunta
    {
        public int PreguntaId { get; set; }
        public string TxtPregunta { get; set; }
        public List<string> ListaDeRespuestas { get; set; }
        public int RespuestaCorrecta { get; set; }
        public  string Asignatura { get; set; }
        public string Unidad { get; set; }
        public string SubUnidad { get; set; }
        public bool Visible { get; set; } 

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}",PreguntaId,TxtPregunta,ListaDeRespuestas,RespuestaCorrecta,Asignatura,Unidad,SubUnidad);
        }
    }
    
}
