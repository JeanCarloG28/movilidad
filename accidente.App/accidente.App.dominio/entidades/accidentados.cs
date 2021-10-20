using System;

namespace accidente.App.dominio
{
    public class accidentados
    {
        public int Id { get; set;}
        public string direccion { get; set;}
        public string barrio { get; set;}
        public string coordenadas { get; set;}
        public string fecha { get; set;}
        public string hora_reporte { get; set;}
        public string hora_accidente { get; set;}
        public string agente_transito { get; set;}
        public string vehiculos_involucrados { get; set;}
        public string personas_involucradas { get; set;}
    }
}