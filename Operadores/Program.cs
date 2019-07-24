using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5,5);

            elementoX.MostrarInformações();

            elementoX.AlterarInformacoes(5, 5);

            elementoX.MostrarInformações();

            Console.ReadKey();
        }
    }
    public class Teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;
        public Teste(int pA, int pB)
        {
            A = pA;
            B = pB;
        }

        public void AlterarInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }
        public void MostrarInformações()
        {
            Console.WriteLine(A + B);
        }
    }
}
