using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoletinEscolarUsandoClass.Biblioteca;

namespace BoletimEscolarEmOutroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var Diario = new Boletim();

            Console.WriteLine("***********************");
            Console.WriteLine("*   Boletim Escolar   *");
            Console.WriteLine("***********************");
            Console.WriteLine("                ");
            Console.WriteLine("Digite a primeira nota");
            int N1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            int N2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            int N3 = Int32.Parse(Console.ReadLine());


            int mediaAlunos = Diario.NotasAlunos(N1, N2, N3);


            Console.WriteLine("Digite a quantidade total de aulas");
            int aulas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade total de faltas do aluno");
            int faltas = Int32.Parse(Console.ReadLine());

            int frequenciaAlunos = Diario.Frequencia(aulas, faltas);

            Diario.Situacao(mediaAlunos, frequenciaAlunos);

            Console.WriteLine($"NOTA: {mediaAlunos} - FREQUENCIA: {frequenciaAlunos}%");



            Console.ReadKey();
        }
    }
}
