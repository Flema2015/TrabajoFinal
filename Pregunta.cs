﻿namespace TrabajoFinal_
{
    public class Pregunta
    {
        public int PreguntaId { get; set; }
        public string TxtPregunta { get; set; }
        public List<string> ListaDeRespuestas { get; set; }
        public int RespuestaCorrecta { get; set; }
        public string Carrera { get; set; }
        public  string Asignatura { get; set; }
        public int Unidad { get; set; }
        public int SubUnidad { get; set; }
        public bool Visible { get; set; }
    }
}
