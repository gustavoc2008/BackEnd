using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public int ano;

        public void Acelerar()
        {
            Console.WriteLine($"Acelerando o veiculo!");
        }
    }
}