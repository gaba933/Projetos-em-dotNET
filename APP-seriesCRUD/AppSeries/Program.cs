// See https://aka.ms/new-console-template for more information
using System;
using AppSeries.models;

namespace AppSeries
{
    class Program
    {
        static SeriesRepositorio repositorio = new SeriesRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarSeries()
        {
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            else
            {
                foreach (var serie in lista)
                {
                    var excluido = serie.retornaExcluido();
                    Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Excluido" : ""));
                }
            }
        }

        private static void InserirSerie()
        {

            Console.WriteLine("Inserir Serie");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da seire: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descricao: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite o Ano da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Serie serie = new Serie(id: repositorio.ProximoID(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno);

            repositorio.Insere(serie);
        }

        public static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id");
            int id = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da seire: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descricao: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite o Ano da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Serie serie = new Serie(id: repositorio.ProximoID(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno);

            repositorio.Atualiza(id, serie);
        }

        public static void ExcluirSerie()
        {
            Console.WriteLine("digite o id");
            int id = int.Parse(Console.ReadLine());

            repositorio.Exclui(id);
        }
        
        public static void VisualizarSerie()
        {
            Console.WriteLine("digite o id");
            int id = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorID(id);

            Console.WriteLine(serie);
        }

         private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}