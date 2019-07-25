using Calculadora.Operadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro Número");
            int num2 = Int32.Parse(Console.ReadLine());


            var operadores = new OperadoresCalc();

            Console.WriteLine($"{num1} + {num2} = {operadores.Adicao(num1,num2)}");
            Console.WriteLine($"{num1} + {num2} = {operadores.Subtracao(num1, num2)}");
            Console.WriteLine($"{num1} + {num2} = {operadores.multipicacao(num1, num2)}");
            Console.WriteLine($"{num1} + {num2} = {operadores.Divisao(num1, num2)}");



            Console.ReadKey();
        }
    }
}
