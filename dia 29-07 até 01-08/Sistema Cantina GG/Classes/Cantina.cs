using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cantina_GG.Classes
{
    public class Cantina
    {
        double saldo = 0;
        double pizza = 5;

        public double Saldo { get { return saldo; } }

        public Cantina()
        {
            saldo = 20; 
        }

        public bool ValorLaches()
        {
            Console.WriteLine("1 - Pizza");
            Console.ReadKey();

            if (pizza <= saldo)
            {
                saldo -= pizza;
                return true;
            }
            return false;


        }
        public double MostarSaldo()
        {
            return saldo;
        }

        public string Menu()
        {
            Console.WriteLine("1 - Comprar um lache");
            Console.WriteLine("2 - Consultar Saldo");
            Console.WriteLine("3 - Sair");

            var opcao = Console.ReadLine();
            return opcao;
        }

        
    }
}
