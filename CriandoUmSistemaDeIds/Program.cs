using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoUmSistemaDeIds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNomes = new string[5, 2];
            int IdParaLista = 0;

            InserirRegistro(ref listaDeNomes, ref IdParaLista);

            Console.ReadKey();

            InserirRegistro(ref listaDeNomes, ref IdParaLista);

            Console.ReadKey();

        }
        public static void InserirRegistro(ref string[,] listaDeNomes, ref int IdParaLista)
        {
            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                if (listaDeNomes[i,1] != null)
                {
                    continue;
                }

                Console.WriteLine("\r\nDigite seu nome");
                string nome = Console.ReadLine();


                listaDeNomes[i, 0] = (IdParaLista++).ToString();

                listaDeNomes[i, 1] = nome;

                Console.WriteLine("Deseja incluir mais um nome a lista?  sim(1)  não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;
            }
            Console.WriteLine("Nomes inseridos com sucesso!! Segue a lista de nomes adicionados");

            for (int i = 0; i < listaDeNomes.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("Registro ID: {0} - Nome: {1}", listaDeNomes[i, 0], listaDeNomes[i, 1]));
            }
        }
    }
}
