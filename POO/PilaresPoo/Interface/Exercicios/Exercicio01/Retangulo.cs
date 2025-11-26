using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float r1;
        public float r2;
        public double resultado;

        public void Perguntas()
        {
            Console.WriteLine($"Digite a Largura do Retangulo");
            r1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a Altura do Retangulo");
            r2 = float.Parse(Console.ReadLine());
        }

        public void CalcularArea()
        {
            resultado = r1 * r2;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Largura do Retangulo: {r1}");
            Console.WriteLine($"Altura do Retangulo: {r2}");
            Console.WriteLine($"Area Calculada: {resultado}");
        }
    }
}