using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraParaOAmiguinho;

namespace UsandoCalculadoraDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();

            Console.WriteLine("Digite um número");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal resultadoAdicao = calculadora.Soma(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {resultadoAdicao}");

            decimal resultadoSubtracao = calculadora.Subtracao(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {resultadoSubtracao}");

            decimal resultadoDivisao = calculadora.Divisao(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {resultadoDivisao}");

            decimal resultadoMultiplicacao = calculadora.Multiplicacao(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {resultadoMultiplicacao}");

            Console.ReadKey();

            Console.WriteLine("RETANGULO");
            Console.WriteLine("Digite a metragem da base do retangulo");
            decimal base1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo");
            decimal altura = decimal.Parse(Console.ReadLine());

            decimal resultadoRetangulo = calculadora.AreaDoRetangulo(base1, altura);

            Console.WriteLine($"Seu Retangulo tem {resultadoRetangulo}m²");

            Console.ReadKey();

            Console.WriteLine("TRIANGULO");
            Console.WriteLine("Digite a metragem da base");
            decimal baseT = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a metragem da altura");
            decimal alturaT = decimal.Parse(Console.ReadLine());

            var resultadoTriangulo = calculadora.AreaDoTriaguloEquilatero(baseT, alturaT);

            Console.WriteLine("");


        }
    }
}
