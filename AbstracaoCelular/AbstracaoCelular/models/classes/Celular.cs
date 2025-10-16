using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoCelular.models.classes
{
    public abstract class Celular
    {
        protected Celular(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void ligar()
        {
            Console.WriteLine("Liagndo");
        }

        public void receberLigacao()
        {
            Console.WriteLine("Recebendo ligacao");
        }

        public abstract void InstalarApp(string nome);
        
    }
}