using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Professor : Pessoa
    {
        public string disciplina;


        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Disciplina: {disciplina}");
        }
    }
}