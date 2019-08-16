using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[10, 5];
            int idBaseDeDados = 0;

            BoasVindas();
            var opcaoMenu = MenuInicial();

            while (opcaoMenu != "5")
            {
                switch (opcaoMenu)
                {
                    case "1": { AdicionarLivros(ref baseDeDados, ref idBaseDeDados); } break;
                    case "2": { RemoverLivroDoEstoque(ref baseDeDados); } break;
                    case "3": { MostrarLivrosNoEstoque(baseDeDados); } break;
                    case "4": { MostrarLivrosNoEstoque(baseDeDados, "true"); } break;
                    
                }
                opcaoMenu = MenuInicial();
            }

        }

        public static void BoasVindas()
        {
            Console.WriteLine("################################################");
            Console.WriteLine("##       BEM VINDO A BIBLIOTECA HBTECH        ##");
            Console.WriteLine("################################################");
            Console.WriteLine("##  DESENVOLVIDO PELAS INDUSTRIAS BLIBLITECH  ##");
            Console.WriteLine("################################################");
        }

        public static string MenuInicial()
        {
            Console.Clear();
            BoasVindas();
            Console.WriteLine("1 - Adicionar um livro ao sistema.");
            Console.WriteLine("2 - Remover um livro do sistema.");
            Console.WriteLine("3 - Listar os livros no sistema.");
            Console.WriteLine("4 - Listar livros Locados");
            Console.WriteLine("5 - Sair do sistema");

            Console.WriteLine("Digite o número da opção desejada!");


            return Console.ReadLine();
        }

        public static void AdicionarLivros(ref string[,] baseDeDados, ref int idBaseDeDados)
        {
            Console.Clear();
            BoasVindas();
            Console.WriteLine("##  Adicionando Livros ao estoque!  ##");

            Console.WriteLine("Informe o nome do Livro!");
            var nomeLivro = Console.ReadLine();

            Console.WriteLine("Informe o nome do autor");
            var nomeAutor = Console.ReadLine();


            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (idBaseDeDados++).ToString();
                baseDeDados[i, 1] = nomeLivro;
                baseDeDados[i, 2] = nomeAutor;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }
            Console.WriteLine("Livro inserido com sucesso!!");
            Console.WriteLine("Para voltar ao menu incial aperte qualquer tecla");
            Console.ReadKey(); 
        }

        public static void RemoverLivroDoEstoque(ref string[,] baseDeDados)
        {
            Console.WriteLine("Removendo Livro dos estoque!");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != "false")
                    Console.WriteLine($"ID: {baseDeDados[i, 0]} - Nome do Livro: {baseDeDados[i, 1]} - Nome do Autor: {baseDeDados[i, 2]}");
            }

            Console.WriteLine("Digite o número do ID para remover o Livro!");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if(baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 3] = "false";

                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            Console.WriteLine("Banco de dados atualizado!!");
            Console.WriteLine("Para voltar ao menu inicial aperte qualquer tecla");
            Console.ReadKey();
        }

        public static void MostrarLivrosNoEstoque(string[,] baseDeDados, string livrosAlocados = "false")
        {
            Console.WriteLine("Banco de Dados da Bliblioteca");

            if (livrosAlocados == "true")
                Console.WriteLine("Livros Alocados:");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != livrosAlocados)
                {
                    Console.WriteLine($"ID: {baseDeDados[i, 0]} - Nome do Livro: {baseDeDados[i, 1]} - Nome do Autor: {baseDeDados[i, 2]}" +
                        $"- Data de Alteração: {baseDeDados[i, 4]}");
                }
            }

            Console.WriteLine("Para voltar ao menu incial aperte qualquer tecla");
            Console.ReadKey();
        }
    }
}
