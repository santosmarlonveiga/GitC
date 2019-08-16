using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {/// <summary>
    /// 
    /// </summary>
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui está inicial, pro joinha");

            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eQuinta"></param>
        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("Carai mermão!!!");
            else
                Console.WriteLine("aiaiaiaiai");

            Console.ReadKey();
        }

        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1","Teste 2" };
        }
    }
}
