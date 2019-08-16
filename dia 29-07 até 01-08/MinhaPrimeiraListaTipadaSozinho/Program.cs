using MinhaPrimeiraListaTipadaSozinho.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipadaSozinho
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> minhaLista = new List<Lanche>();
            {
                for (int i = 0; i < 1; i++)
                {
                    
                    minhaLista.Add(new Lanche()
                    {
                        
                        Nome = Console.ReadLine(),
                        Quantidade = int.Parse(Console.ReadLine()),
                        Valor = double.Parse(Console.ReadLine())
                    });
                    Console.ReadKey();
                }
                foreach (Lanche item in minhaLista)
                {
                    Console.WriteLine($"Laches disponiveis: {item.Nome}");
                }
                Console.ReadKey();
            }
        }
    }
}
