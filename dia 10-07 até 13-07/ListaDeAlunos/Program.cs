using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAlunos
{
    class Program
    {
        static string[,] baseDadosAlunos;
        static void Main(string[] args)
        {
            BancoDeDadosAlunos();

            Console.WriteLine("Lista de alunos:");

            ListarNomes();

            Console.ReadKey();
        }

        public static void BancoDeDadosAlunos()
        {
            baseDadosAlunos = new string[20, 3]
            {
                {"Arthur","20","Masculino" },
                {"Miguel","19","Masculino" },
                {"Luís","25","Masculino" },
                {"Ana Clara","15","Feminino" },
                {"Henrique","12","Masculino" },
                {"Léo","36","Masculino" },
                {"Victor","30","Masculino" },
                {"Bianca","22","Feminino" },
                {"Benjamim","23","Masculino" },
                {"João Rafael","28","Masculino" },
                {"Luisa","16","Feminino" },
                {"Brenda","17","Feminino" },
                {"Joaquim","21","Masculino" },
                {"Rafael","31","Masculino" },
                {"João Pedro","25","Masculino" },
                {"Aline","23","Feminino" },
                {"José Pedro","20","Masculino" },
                {"Octávio","19","Masculino" },
                {"Antônia","15","Feminino" },
                {"Celine","13","Feminino" },
            };
        }

        public static void ListarNomes()
        {
            for (int i = 0; i < baseDadosAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDadosAlunos[i, 0]} Idade: {baseDadosAlunos[i, 1]} Sexo: {baseDadosAlunos[i, 2]}");
            }
        }
    }
}
