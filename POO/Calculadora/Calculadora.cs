using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculator
    {
        public double n1;

        public double n2;

        public double resultado;

        public double Somar()
        {
            resultado = n1 + n2;
            return resultado;
        }

        public double Subtrair()
        {
            resultado = n1 - n2;
            return resultado;          
        }

        public double Multiplicar()
        {
            resultado = n1 * n2;
            return resultado;
        }

        public double Dividir()
        {
            resultado = n1 / n2;
            return resultado;
        }
    }
}