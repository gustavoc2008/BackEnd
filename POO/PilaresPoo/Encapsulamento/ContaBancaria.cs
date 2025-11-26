using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if(saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            else
            {
                Saldo = 0;
            }
        }

        public void Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine($"Valor Invalido");
            }
        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine($"Saldo Insuficiente para Saque");
            }
            else if (valor <= 0)
            {
                Console.WriteLine($"So pode sacar valores positivos");
            }
            else
            {
                Saldo -= valor;
            }
        }
    }
}