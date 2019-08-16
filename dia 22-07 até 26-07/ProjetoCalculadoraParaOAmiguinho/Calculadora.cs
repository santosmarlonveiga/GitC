using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadoraParaOAmiguinho
{
    public class Calculadora
    {
        public int multipicacao(int A, int B)
        {
            return A * B;
        }
        public int Divisao(int A, int B)
        {
            return A / B;
        }
        public int Adicao(int A, int B)
        {
            return A + B;
        }
        public int Subtracao(int A, int B)
        {
            return A - B;
        }
        public int CalcularRetangulo(int A,int B)
        {
            return A * B;
        }
        public int CalcularTriangulo(int B, int A)
        {
            return (B * A) / 2;
        }
        public float CalcularRaioDeUmCirculo(float A)
        {
            
            return A / 6.28f; 
        }
       
    }
}
