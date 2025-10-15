using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSeries.models
{
    public class SeriesRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie obj)
        {
            listaSerie[id] = obj;
        }

        public void Exclui(int id)
        {
            listaSerie[id].excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
           return listaSerie;
        }

        public int ProximoID()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorID(int id)
        {
            return listaSerie[id];
        }
    }
}