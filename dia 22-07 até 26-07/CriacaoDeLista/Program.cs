using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriacaoDeLista.Calsses;

namespace CriacaoDeLista
{
    class Program
    {
        //Versão 2.0 agora com nome correto
        static void Main(string[] args)
        {
            Listas objetoLista = new Listas();
            objetoLista.carregaListas();
            objetoLista.listar();

            objetoLista.limpar();
            objetoLista.listar();
        }
    }
}
