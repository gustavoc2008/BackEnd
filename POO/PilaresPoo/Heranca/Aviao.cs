using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int CapacidadePassageiros;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Capacidade de Passageiros: {CapacidadePassageiros}");
        }

        public void SomDoAviao()
        {
            Console.WriteLine($"Vonnnnn");
        }
    }
}