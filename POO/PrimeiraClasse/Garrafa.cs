using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Garrafa
    {
        public string Cor;

        public int Tamanho;

        public int Capacidade;

        public string Formato;

        public string Marca;

        public void Abrir()
        {
            Console.WriteLine($"Thro...");
        }

        public void Beber()
        {
            Console.WriteLine($"Gluh, Gluh, Gluh...");
        }
    }
}