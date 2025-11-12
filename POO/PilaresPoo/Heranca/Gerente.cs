using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
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