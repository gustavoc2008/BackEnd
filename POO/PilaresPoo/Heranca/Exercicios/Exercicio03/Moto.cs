using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Moto : Veiculo
    {
        public int QntdCilindradas;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Quantidade de Cilindros: {QntdCilindradas}");
        }

        public void SomDaMoto()
        {
            Console.WriteLine($"Som da Moto: zum, zum, zummmmmmmmmmmmm");
        }

        public void Acelerar()
        {
            Console.WriteLine($"UUUU tu tu tu tuuuuuuuuuuuuuu");
        }
    }
}