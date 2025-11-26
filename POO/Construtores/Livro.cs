using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Livro
    {
        public string titulo;
        public string autor;
        public float preco;

        public Livro(string t, string a, float p)
        {
            titulo = t;
            autor = a;
            preco = p;

            ExibirDados();
        }

        public Livro(string t, string a)
        {
            titulo = t;
            autor = a;

            ExibirDados();
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titulo: {titulo}, Autor: {autor} e Preco R${preco}");
        }
    }
}