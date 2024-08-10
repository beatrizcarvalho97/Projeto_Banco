using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    internal class ContaBancaria
    {
        public int agencia,numeroConta;
        public string titularConta;
        public double valor, saldo = 100;

        public void Realiza_Saque()
        {
            /* double realizaSaque;
             realizaSaque = saldo - valor;
            */
            saldo -= valor; // Saldo = saldo - valor
        }

        public void Realiza_Deposito()
        {
            /* double realizaDeposito;
            realizaDeposito = saldo + valor;
            */

            saldo += valor; // Saldo = saldo + valor
        }
    }
}
