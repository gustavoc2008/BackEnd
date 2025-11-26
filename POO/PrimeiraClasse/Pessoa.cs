using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Pessoa
    {
        //atributos
        public string nome;

        public int idade;

        public string jogosZerados;


        //metodos
        public void Falar()
        {
            Console.WriteLine($"Ola meu nome eh {nome} e eu ja zerei todos os {jogosZerados} com apenas {idade} anos. Isso eh a diferenca de um fa pra um fanboy");
        }

        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                idade += _id;
            }

            else
            {
                idade++;
            }
        }
    }
}
