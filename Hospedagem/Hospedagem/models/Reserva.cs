using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.models
{
    public class Reserva
    {
        public Reserva( int diasReservados)
        {
            
            this.DiasReservados = diasReservados;
        }
        private List<Pessoa> Hospedes = new List<Pessoa>();   

        private Suite Suite { get; set; }
        
        private int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {   
            if (hospedes.Count > Convert.ToInt32(Suite.Capacidade))
            {
                Console.WriteLine($"A capacidade da suíte é de {Suite.Capacidade} hóspedes. Por favor, verifique a quantidade de hóspedes.");
            } else
            {
                this.Hospedes = hospedes;
                Console.WriteLine($"Hóspedes cadastrados com sucesso!");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
            Console.WriteLine($"Suíte cadastrada com sucesso!");
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal Valor = 0;
            
            if (DiasReservados >= 10)
            {
                var desconto = 10 / 100m;
                Valor = (Suite.ValorDiaria * DiasReservados) - ((Suite.ValorDiaria * DiasReservados) * desconto);
            } else
            {
                Valor = Suite.ValorDiaria * DiasReservados;
            }
            return Valor;
        }
        
    }
}