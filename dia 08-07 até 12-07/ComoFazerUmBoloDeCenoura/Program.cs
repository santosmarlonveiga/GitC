using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComoFazerUmBoloDeCenoura
{
    class Program
    {
        static string[] baseDadosBolo;
        static void Main(string[] args)
        {
            BancoDeDadosBolo();

            BemVindo();

            for (int i = 0; i < baseDadosBolo.GetLength(0); i++)
            {
                Console.WriteLine($"{baseDadosBolo[i]}");
                Console.ReadKey();
            }
        }
        public static void BancoDeDadosBolo()
        {
            baseDadosBolo = new string[20]

                {"MASSA:",
                "3 cenouras picadas",
                "3 ovos",
                "1 xícara de óleo de soja",
                "3 xícaras de farinha de trigo",
                "2 xícaras de açúcar",
                "1 colher de fermento químico em pó",
                "COBERTURA:",
                "4 colheres cheias de açúcar",
                "2 colheres cheias de chocolate em pó",
                "1 colher de manteiga",
                "Um pouquinho de leite, apenas para desmanchar",
                "MODO DE PREPARO.",
                "MASSA:",
                "Bata a cenoura, os ovos e o óleo no liquidificador.",
                "Em uma vasilha à parte, misture os outros ingredientes e coloque em tabuleiro untado.",
                "Asse em forno médio, pré-aquecido, por 30 a 40 minutos.",
                "COBERTURA:",
                "Coloque todos os ingredientes em uma panela e leve ao fogo, sempre mexendo, até ferver um pouco.",
                "Faça furos no bolo para o chocolate escorrer pelo meio do bolo."
                };
        }
        public static void BemVindo()
        {
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("*  Bem vindo ao Tutorial de como faze um bolo de cenoura com cobertura de chocolate  *");
            Console.WriteLine("**************************************************************************************");
        }
    }
}
