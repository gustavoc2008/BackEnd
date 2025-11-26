using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Pessoa
    {
        public string nome;
        public int idade;


        public Pessoa()
        {
        }

        public Pessoa(string n)
        {
            nome = n;
        }
        
        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");   
        }
    }
}