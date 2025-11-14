using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Carro : Veiculo
    {
        public int QntdPortas;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Quantidade de Portas: {QntdPortas}");
        }
        
        public void SomDoCarro()
        {
            Console.WriteLine($"Som do Carro: Brummmmmmm");
        }
    }
}