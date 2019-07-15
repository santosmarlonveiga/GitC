using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando nossa lista com mais de uma dimenção
            string[,] listaDeNomes = new string[5, 2];


            //Aqui como estamos usando apenas uma referencia da nossa lista colocamos ref ao passar ela no metodo
            CarregaInformacoesEListaElasEmTela( listaDeNomes);

            //Após carregar as informações e mostrar em lista ele espera o comando
            Console.ReadKey();

            //Indicamos que o usuario precisa informar um número de indentificação para pesquisar um registro.
            Console.WriteLine("informe o ID do registro a ser pesquisado.");
            //Aqui como realizamo a pesquisa somente na chamada
            //Passamos a nossa lista normalmente pois não iremos alterar e apenas pesquisar a informação
            //Após a virgula temos o console readLine qye espera nosso identificador unico
            PesquisandoInformacoesNaNossaLista(listaDeNomes, Console.ReadLine());

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista crianda no metodo MAIN
        /// e mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        /// /// <param name="pId">Nosso identificador unico</param>
        public static void CarregaInformacoesEListaElasEmTela( string[,] arrayBi)
        {
            //usando um laço simples para colocar valores mas no mesmo agora utilizando o 
            //GetLength cin i oarametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso geristro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Felipe_{i}";
            }

            //Lembrando qye GetLength é um método e usamos "(pararametros)" com parametro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos yma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }
        }
        public static void PesquisandoInformacoesNaNossaLista( string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmos tipos
                if (arrayBi[i, 0] == pId)
                {
                    //Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informações escolhida: id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista amas retornamos vazio "return", pois estamos em um metodo
                    //vazio "void" que não espera retornar algo
                    return;
                }
            }
            //Caso ele passe por essa linha identificamos que ele não encontrou resultados compativeis
            Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação");
        }
    }
}
