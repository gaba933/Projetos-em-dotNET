using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.models
{
    public class Suite
    {
        public Suite(string tipoSuite, string capacidade, decimal ValorDiaria)
        {
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = ValorDiaria;
        }

        public string TipoSuite { get; set; }

        public string Capacidade{ get; set; }
        public decimal ValorDiaria { get; set; }

    }
}