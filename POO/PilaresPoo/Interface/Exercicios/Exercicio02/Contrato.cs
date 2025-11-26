using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Cliente = "";
        public double Documento = 0;
        public string Descricao = "";
        public string Obrigacao = "";
        public string Penalidade = "";


        public Contrato(string nomeCliente, float CPF, string desc, string obri, string pena)
        {
            Cliente = nomeCliente;
            Documento = CPF;
            Descricao = desc;
            Obrigacao = obri;
            Penalidade = pena;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Contrato...");
            Thread.Sleep(5000);

            Console.WriteLine($"Contrato Imprimido!");
            Console.WriteLine($"");
            
            Console.WriteLine(@$"
    Nome do Cliente: {Cliente}
    Documento: {Documento}
    Descricao do Contrato: {Descricao}
    Obrigacao a ser cumprida do Contrato: {Obrigacao}
    Penalidade caso a obrigacao nao seja cumprida: {Penalidade}
            ");
        }
    }
}