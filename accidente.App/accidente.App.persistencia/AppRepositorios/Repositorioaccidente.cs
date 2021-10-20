using System.Collections.Generic;
using System.Linq;
using accidente.App.dominio;



namespace accidente.App.persistencia
{
    public class Repositorioaccidente : IRepositorioaccidente 
    {
        ///<summary>
        ///referenciar
        ///</summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// metodo constructor
        /// inyeccion de dependencias
        ///</summary>
        ///<param name="appContext"></param>

        public Repositorioaccidente(AppContext appContext)
        {
            _appContext=appContext;
        }


        public accidentados Addaccidentados(accidentados  accidentados)
        {
            var accidentadosAdicionado= _appContext.accidentados.Add(accidentados);
            _appContext.SaveChanges();
            return accidentadosAdicionado.Entity;
        }



        public void Deleteaccidentados(int Idaccidentados)
        {
            var accidentadosEncontrado=_appContext.accidentados.FirstOrDefault(p => p.Id==Idaccidentados);
            if(accidentadosEncontrado==null)
             return;
            _appContext.accidentados.Remove(accidentadosEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<accidentados> GetAllaccidentados()
        {
            return _appContext.accidentados;
        }

        public accidentados Getaccidentados(int Idaccidentados)
        {
         return _appContext.accidentados.FirstOrDefault(p => p.Id==Idaccidentados);

        } 

        public accidentados Updateaccidentados(accidentados  accidentados)
        {
            var accidentadosEncontrado=_appContext.accidentados.FirstOrDefault(p => p.Id==accidentados.Id);
            if(accidentadosEncontrado!=null)
            {
                accidentadosEncontrado.Id =accidentados.Id;
                accidentadosEncontrado.direccion =accidentados.direccion;
                accidentadosEncontrado.barrio =accidentados.barrio;
                accidentadosEncontrado.coordenadas =accidentados.coordenadas;
                accidentadosEncontrado.fecha =accidentados.fecha;
                accidentadosEncontrado.hora_reporte =accidentados.hora_reporte;
                accidentadosEncontrado.hora_accidente =accidentados.hora_accidente;
                accidentadosEncontrado.agente_transito =accidentados.agente_transito;
                accidentadosEncontrado.vehiculos_involucrados =accidentados.vehiculos_involucrados;
                accidentadosEncontrado.personas_involucradas =accidentados.personas_involucradas;

                _appContext.SaveChanges();
          
            }
            return accidentadosEncontrado;
        }
    }
}