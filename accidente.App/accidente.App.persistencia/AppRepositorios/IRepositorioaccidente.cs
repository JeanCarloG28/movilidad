using System.Collections.Generic;
using accidente.App.dominio;

namespace accidente.App.persistencia
{
    public interface IRepositorioaccidente
    {
        public IEnumerable<accidentados> GetAllaccidentados();

        public accidentados Addaccidentados(accidentados accidentados);

        public accidentados Updateaccidentados(accidentados accidentados);

        public void Deleteaccidentados(int Idaccidentados);

        public accidentados Getaccidentados(int idaccidentados);

    }
}