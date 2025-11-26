using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string nomeAutor = "";
        public string Titulo = "";
        public string Analise = "";
        public string Feito = "";
        public string Conclusao = "";

        public Relatorio(string n, string t, string a, string f, string c)
        {
            nomeAutor = n;
            Titulo = t;
            Analise = a;
            Feito = f;
            Conclusao = c;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Relatorio...");
            Thread.Sleep(5000);

            Console.WriteLine($"Relatorio Imprimido!");
            Console.WriteLine($"");
            
            Console.WriteLine(@$"
    Nome do Autor: {nomeAutor}
    Titulo do Relatorio: {Titulo}
    Analise do Relatorio: {Analise}
    O que foi Feito: {Feito}
    Conclusao do Relatorio: {Conclusao}
            ");
        }
    }
}