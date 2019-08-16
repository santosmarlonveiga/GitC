using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletinEscolarUsandoClass.Biblioteca
{
    public class Boletim
    {
        public int NotasAlunos(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public int Frequencia(int totalAulas, int totalFaltas)
        {
            return ((totalAulas - totalFaltas) * 100) / totalAulas;
        }

        public string Situacao(int media, int frequenciaTotal)
        {
            if ((media >= 7) && (frequenciaTotal >= 75))
                return "Aprovado";

            return "Reprovado";
        }
    }

    
}
