using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Carro
    {
        public string marca;
        public string modelo;
        public int ano;


        public Carro(string n, string m, int a)
        {
            marca = n;
            modelo = m;
            ano = a;

            ExibirDados();
        }


        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo} e Ano: {ano}");
        }
    }
}