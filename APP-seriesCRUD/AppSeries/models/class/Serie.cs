using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSeries.models
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano;
            return retorno;
        }

        public int retornaId()
        {
            return this.id;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public void excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
		{
			return this.Excluido;
		}

    }
}