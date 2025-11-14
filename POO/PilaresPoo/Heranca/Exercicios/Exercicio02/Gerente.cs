using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public void ExibirSalario()
        {
            double salarioTotal = CalcularSalario();
            Console.WriteLine($"Salario Base: {salarioBase}");
            Console.WriteLine($"Salario Total: {salarioTotal}");
        }
    }
}