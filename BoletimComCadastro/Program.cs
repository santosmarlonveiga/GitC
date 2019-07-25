using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoletinEscolarUsandoClass.Biblioteca;

namespace BoletimComCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            var Diario = new MenuDeOpções();

            var opcaoMenu = Diario.Menu();

            while (opcaoMenu != "5")
            {
                switch (opcaoMenu)
                {
                    case "1": { Diario.CadastrarNotaDoAluno(); } break;
                    case "2": { Diario.MostrarAlunos(); } break;
                    case "3": { Diario.ExcuirRegistro(); } break;
                    case "4": { Diario.AlterarNotas(); } break;

                }
                opcaoMenu = Diario.Menu();
            }
        }
    }
}
