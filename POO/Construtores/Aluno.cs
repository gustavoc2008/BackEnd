using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Aluno
    {
        public string nome;
        public float nota;


        public Aluno()
        {
        }
        public Aluno(string n, int N)
        {
            nome = n;
            nota = N;
        }
        

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome} e Nota: {nota}"); 
        }
    }
}