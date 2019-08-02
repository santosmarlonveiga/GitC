using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta
    {
        double saldo = 0;

        public double Saldo { get;{ return saldo; } }
        public Conta()
        {
            //bonus de 1000 reais pra iniciar operar daytrade
            saldo = 1000;
        }
        /// <summary>
        /// metodo para sacar de acordo com saldo disponível
        /// </summary>
        /// <param name="valor">valor para sacar</param>
        /// <returns>retorna se o saque foi feito ou não</returns>
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                //Desconta  do valor em saldo da conta
                saldo -= valor;
                return true;
            }
            //retorna falso em caso de não conter saldo disponivel
            return false;
           
        }
        /// <summary>
        /// Metodo para mostrar o saldo em conta disponivel
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
