using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocação_de_carro
{
    class Program
    {
        static string[,] baseDeDadosCarros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarBemVindo();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarCarro();

                if (opcaoMenu == 3)
                {
                    Console.Clear();
                    MostrarBemVindo();
                    MostrarListaDeCarros();
                    Console.Read();
                }

                opcaoMenu = MenuPrincipal();

            }

            Console.ReadKey();
        }   
        /// <summary>
        /// Metodo que mostra a mensagem de boas vindas
        /// </summary>
        public static void MostrarBemVindo()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+  Bem vindo ao Perfect Car alocação    +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+    Desenvolvido por Marlon Veiga      +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
        }
        /// <summary>
        /// Metodo que mostra o menu incial com duas opções
        /// </summary>
        /// <returns>Retorna o número escolhido no menu</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarBemVindo();

            Console.WriteLine("Menu inicial");
            Console.WriteLine("O que você deseja realizar");
            Console.WriteLine("1 - Alocar um carro.");
            Console.WriteLine("2 - Desalocar um Carro");
            Console.WriteLine("3 - Listagem dos Carros");
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite a opção desejada.");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;

        }
        /// <summary>
        /// Metodo que carrega a base de dados dos carros
        /// </summary>
        public static void CarregaBaseDeDados()
        {
             baseDeDadosCarros = new string[5, 4]
             {

                { "Gol G6", "2017","$54,50", "sim"},
                {"Fiat Toro", "2018","$103,20", "sim"},
                 {"Sandero","2011","$65,00","sim"},
                 {"Jetta","2018","$125,80","sim"},
                 {"Logan","2015","$89,00","sim"}
             };
        }
/// <summary>
/// Metodo que pesquisa um carro para ser alocado
/// </summary>
/// <returns>Retorna verdadeiro em caso do carro estiver livre para ser alocado</returns>
        public static bool PesquisaCarroAlocaçao(string nomeDoCarro)
        {
            for (int i = 0; i < baseDeDadosCarros.GetLength(0); i++)
            {
                if (nomeDoCarro == baseDeDadosCarros[i, 0])
                {
                    Console.WriteLine($"O Carro: {nomeDoCarro}| Ano: {baseDeDadosCarros[i, 1]}| Valor diário: {baseDeDadosCarros[i,2]}| Está disponível?: {baseDeDadosCarros[i, 3]}");

                    return baseDeDadosCarros[i, 3] == "sim";
                }
            }
            return false;
        }

        public static void AtualizarCarro(string nomeDoCarro, bool alocar)
        {

            for (int i = 0; i < baseDeDadosCarros.GetLength(0); i++)
            {
                if (nomeDoCarro == baseDeDadosCarros[i, 0])
                {
                    baseDeDadosCarros[i, 3] = alocar? "não" : "sim";
                }
            }
            Console.Clear();
            MostrarBemVindo();
            Console.WriteLine("Carro alocado com sucesso!!");
        }

        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("Alocar Carro: ");

            var nomeDoCarro = Console.ReadLine();
            if (PesquisaCarroAlocaçao(nomeDoCarro))
            {
                Console.Clear();
                MostrarBemVindo();
                Console.WriteLine("Você deseja alocar o carro? para sim(1) para não(2)");

                AtualizarCarro(nomeDoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }

        public static void MostrarListaDeCarros()
        {
            Console.WriteLine("Listagem de Carros: ");
            
            for (int i = 0; i < baseDeDadosCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeDadosCarros[i, 0]}| Ano: {baseDeDadosCarros[i, 1]}| Valor Diário: {baseDeDadosCarros[i, 2]}|  Disponível?: {baseDeDadosCarros[i, 3]}");
            }
        }
        public static void DesalocarCarro()
        {
            MostrarMenuInicialCarros("Desalocar Carro:");


            var nomedoCarro = Console.ReadLine();
            if (!PesquisaCarroAlocaçao(nomedoCarro))
            {
                Console.Clear();
                MostrarBemVindo();
                Console.WriteLine("Você deseja desalocar um carro? para sim(1) para não(2)");

                AtualizarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            MostrarBemVindo();

            Console.WriteLine($"Menu {operacao}");
            Console.WriteLine("Digite o nome do carro para realizar a operação:");
        }
    }
}