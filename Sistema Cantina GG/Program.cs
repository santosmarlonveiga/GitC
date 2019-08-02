using Sistema_Cantina_GG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Cantina_GG
{
    class Program
    {
        static void Main(string[] args)
        {
            Cantina cantina = new Cantina();

            var opcao = cantina.Menu();
            while (opcao != "3")
            {
                switch (opcao)
                {
                    case "1": { cantina.ValorLaches(); } break;
                    case "2": { cantina.MostarSaldo(); } break;
                }
            }


        }
    }
}
