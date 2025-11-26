using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Moto : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;


        public Moto(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }


        public void ExibirInfo()
        {
            Console.WriteLine(@$"
Informações do Veiculo
    Marca: {Marca}
    Modelo: {Modelo}
    Ano: {Ano}
    Cor: {Cor}
            ");

        }
        public void Acelerar()
        {
            Console.WriteLine($"Moto Ligando...");
            Thread.Sleep(3000);
            Console.WriteLine($"Moto Acelerando: RANDANDANNNNN");
            Thread.Sleep(3000);
        }

        public void Frear()
        {
            Console.WriteLine($"Moto Freiando: IRRRRRRRRRRRRRRRR");
            Thread.Sleep(3000);
            Console.WriteLine($"Moto Desligando...");
            Thread.Sleep(3000);
        }

    }
}