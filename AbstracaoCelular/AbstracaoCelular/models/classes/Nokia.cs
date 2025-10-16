using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoCelular.models.classes
{
    public class Nokia: Celular 
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        
       
        public override void InstalarApp(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Nokia");
        }
    }
}