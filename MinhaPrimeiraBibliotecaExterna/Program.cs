using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeArquivosDoWindows;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var retornaDocumento = new GetFiles().RetornaArquivosDoMeuDocumentos();

            var retornaGitC = new GetFiles().RetornaArquivosGit();

            var retornaImagens = new GetFiles().RetornaArquivosImagesFiles();

            for (int i = 0; i < retornaDocumento.Length; i++)
            {
                Console.WriteLine(retornaDocumento[1]);
            }

            Console.ReadKey();

            for (int i = 0; i < retornaImagens.Length; i++)
            {
                Console.WriteLine(retornaImagens[i]);
            }
            Console.ReadKey();

            for (int i = 0; i < retornaGitC.Length; i++)
            {
                Console.WriteLine(retornaGitC[i]);
            }
            Console.ReadKey();
        }
    }
} 
