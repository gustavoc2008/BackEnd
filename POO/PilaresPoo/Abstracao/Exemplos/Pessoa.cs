using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string nome;

        public int idade;


        public void Dormir()
        {
            Console.WriteLine($"ZZZZZZZZZZZZZZ!!!");
        }

        public override void FazerSom()
        {
            Console.WriteLine($"HIRI, HAUUU, LEAVE ME ALONE");
        }

        public override void Mover()
        {
            Console.WriteLine($"Toc, Toc, Toc");
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}