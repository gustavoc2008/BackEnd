using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            saldo += valor;
        }

        public override void Sacar(double valor)
        {
            double Taxa = valor + (valor * 3 /100);

            if(valor <= 0)
            {
                Console.WriteLine($"Valor Invalido");
            }
            else if(valor > saldo)
            {
                Console.WriteLine($"Saldo Insuficiente");
            }
            else
            {
                saldo -= Taxa;
            }
        }
    }
}