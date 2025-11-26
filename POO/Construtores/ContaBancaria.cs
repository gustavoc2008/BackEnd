using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class ContaBancaria
    {
        public string titular;
        public double saldo;


        public ContaBancaria()
        {
        }

        public ContaBancaria(string t, double s)
        {
            titular = t;
            saldo = s;

            ExibirDados();
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {titular} e Saldo R${saldo}");
        }
    }
}