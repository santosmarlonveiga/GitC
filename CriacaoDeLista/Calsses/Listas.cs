using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista.Calsses
{
    class Listas
    {
        //Iniciando uma lista de string com array linear
        string[] lista;

        public void carregaListas() {
            lista = new string[10];
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");

            }
        }

        public void listar() {
            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            Console.WriteLine("Listabndo dados............");
            foreach (var item in lista)//"var item" indica uma unidade da nossa lista "in lista" 
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();
        }


        public void limpar() { 
            for (int i = 0; i<lista.Length; i++)
                lista[i] = string.Empty;//Aqui limpamos o nosso valor dentro da coleção
       }
           
    }
}
