using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeBebidasOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            BemVindo();

            Console.WriteLine("\r\nDigite seu nome:");
            string nome = Console.ReadLine();

            var opcaoMenu = MenuDeEscolha();
            while (opcaoMenu != 2)
            {
                if (opcaoMenu == 1)
                {
                    VerificaIdade();
                }
            }    Console.ReadKey();        
        }
        public static int MenuDeEscolha()
        {
            Console.WriteLine("Qual tipo de Bebida você gostaria de comprar?");
            Console.WriteLine("1 - Bebidas alcólicas.");
            Console.WriteLine("2 - Sair do sistema.");
            Console.ReadKey();

            VerificaIdade();

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }

        public static void BemVindo()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*  Bem vindo a Loja de Bebidas Online do Marlon  *");
            Console.WriteLine("**************************************************");
        }
        public static void MenuDeBebidas()
        {
            Console.WriteLine("1 - Vodka Absolut");
            Console.WriteLine("2 - Whiskey Red Label");
            Console.WriteLine("3 - Whiskey Black Label");
            Console.WriteLine("4 - Whiskey Gold Label");
        }

        public static void VerificaIdade()
        {
            Console.WriteLine("\n\rDigite sua idade: ");
            int.TryParse(Console.ReadLine(), out int idade);
            if (idade < 18)
            {
                Console.WriteLine("Você não tem idade para essa opção");
                Console.ReadKey();
            }else
                MenuDeBebidas();
        }
    }
}
