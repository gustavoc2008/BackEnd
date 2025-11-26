using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float c1;
        public double resultado;

        public void Perguntas()
        {
            Console.WriteLine($"Digite o Raio do Circulo");
            c1 = float.Parse(Console.ReadLine());
        }

        public void CalcularArea()
        {
            resultado = Math.PI * Math.Pow(c1, 2);
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Raio do Circulo: {c1}");
            Console.WriteLine($"Area Calculada: {resultado}");
        }
    }
}