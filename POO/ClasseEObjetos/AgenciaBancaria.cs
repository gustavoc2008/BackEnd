using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class ContaBancaria
    {
        public string Titular = "";

        public float Saldo;

        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"O valor de deposito precisa ser maior que 0");
                return;
            }
            Saldo += valor;
        }
        
        public void Sacar(float valor)
        {
            if (valor <= 0 && valor < 0)
            {
                Console.WriteLine($"O valor de saque precisa ser maior que 0");
                return;
            }
            Saldo -= valor;
        }
    }
}