﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class.MyFirstClass
{
    class Carro
    {
        int rodas = 0;
        int portas = 0;
        int bancos = 0;
        int janelas = 0;

        public void MostrarCarro()
        {
            Console.WriteLine($"Nosso Carro:\r\n" +
                $" Quant Rodas:[{rodas}]\r\n" +
                $"Quant Portas:[{portas}]\r\n" +
                $"Quant Bancos:[{bancos}]\r\n" +
                $"Quant Janelas:[{janelas}]");
        }
    }
}
