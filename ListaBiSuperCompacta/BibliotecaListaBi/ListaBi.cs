using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;

        

        /// <summary>
        /// Iniciamos nossa lista bi, agora quando iniciamos uma instancia dela ela ja vem com a lista carregada
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[5, 2];

            //Ao chamar este metodo no contrutor nossa lista já vai estar carregada
            //ao iniciar a instancia "jogar pra memoria"
            CarregaListaBi();

        }
        /// <summary>
        /// Aqui ja carregamos a lista quando chamado este metodo
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Felipe_{i}";

                //Ao adicionar o registro na lista ja mostramos na tela
                Console.WriteLine($"Id:{i} Nome: Felipe_{i}");
            }
        }
        /// <summary>
        /// Aqui temos o metodo que realiza a pesquisa das informações em nossa 
        /// lista 
        /// </summary>
        /// <param name="idPesquisa">Aqui vai o ID da nossa informação</param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if (listaBi[i, 0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!!");
                    Console.WriteLine($"Você pesquisou pelo registro: {listaBi[i, 0]}");
                    //saio do metodo por que preciso mais dele sem passar nada por que ele e um void "vazio, sem tipo"
                    return;
                }
            }

            Console.WriteLine("Nenhum registro foi encontrado com esse Id!");
        }
    }
}
