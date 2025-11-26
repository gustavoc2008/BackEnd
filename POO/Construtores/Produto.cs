using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        public string nome;
        public float preco;
        public int estoque;


        public Produto(string n, float p, int e)
        {
            nome = n;
            preco = p;
            estoque = e;

            ExibirDados();
        }

        public Produto()
        {
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome do Produto: {nome}, Preco R${preco} e Quantidade no estoque: {estoque}");
        }
    }
}