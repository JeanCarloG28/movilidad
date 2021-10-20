using System;
using accidente.App.dominio;
using accidente.App.persistencia;

namespace accidente.App.consola
{
    class Program
    {
        private static IRepositorioaccidente _repoaccidentados= new Repositorioaccidente(new persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            //Addaccidentados();
            //Buscaraccidentados();
        }

        private static void Addaccidentados()
        {
            var accidentados = new accidentados
            {
        
             direccion="avenida 30",
             barrio="tunal",
             coordenadas="N45o87e25",
             fecha="27 de septiembre de 2021",
             hora_reporte="17:50",
             hora_accidente="17:30",
             agente_transito="luis perez",
             vehiculos_involucrados="mazda 3",
             personas_involucradas="felipe gomez",
             
            };

            _repoaccidentados.Addaccidentados(accidentados);
        }
      private static void Buscaraccidentados(int Idaccidentados)
      {
          var accidentados = _repoaccidentados.Getaccidentados(Idaccidentados);
          Console.WriteLine(accidentados.barrio+" "+accidentados.personas_involucradas);
      }

    }
}
