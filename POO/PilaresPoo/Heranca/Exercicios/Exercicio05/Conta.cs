using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Conta
    {
        public float numero;
        public double saldoBase;
        public double saldoAtual;
        public double QntdDeposito;
        public double QntdSacar;


        public void ExibirInfo()
        {
            Console.WriteLine($"Saldo: {saldoBase}");
        }

        public void ExibirInfo2()
        {
            Console.WriteLine($"Saldo Atual: {saldoAtual}");
        }

        public double Depositar()
        {
            return saldoAtual = saldoBase += QntdDeposito;
        }

        public double Sacar()
        {
            if (QntdSacar <= 0)
            {
                Console.WriteLine($"Valor Invalido");
                return saldoBase;
            }
            else if (QntdSacar > saldoBase)
            {
                Console.WriteLine($"Saldo Insuficiente para Saque!!!");
                return saldoBase;
            }
            else
            {
                return saldoAtual = saldoBase -= QntdSacar;
            }
        }

        public void Exibir()
        {
            Console.WriteLine($"Realizando Deposito...");
            Thread.Sleep(2000);

            Console.WriteLine($"Deposito Realizado");
        }

        public void Exibir2()
        {
            Console.WriteLine($"Realizando Saque...");
            Thread.Sleep(4000);

            Console.WriteLine($"Saque Realizado");
        }
    }
}