using System;
using Hospedagem.models;

namespace Hospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa pessoa1 = new Pessoa("João", "Silva");
            Pessoa pessoa2 = new Pessoa("Maria", "Oliveira");

            hospedes.Add(pessoa1);
            hospedes.Add(pessoa2);

            Suite suite = new Suite("Premium", "2", 100);
            Suite suite2 = new Suite("media", "4", 200);

            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
            Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
        }
    }
}