using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Carro : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;


        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }


        public void ExibirInfo()
        {
            Console.WriteLine(@$"
Informações do Veiculo:
    Marca: {Marca}
    Modelo: {Modelo}
    Ano: {Ano}
    Cor: {Cor}
            ");
            
        }
        public void Acelerar()
        {
            Console.WriteLine($"Carro Ligando...");
            Thread.Sleep(3000);
            Console.WriteLine($"Carro Acelerando: VRUMMMMMM");
            Thread.Sleep(3000);
        }

        public void Frear()
        {
            Console.WriteLine($"Carro Freiando: IRRRRRRRRRRRRRRRR");
            Thread.Sleep(3000);
            Console.WriteLine($"Carro Desligando...");
            Thread.Sleep(3000);
        }
    }
}