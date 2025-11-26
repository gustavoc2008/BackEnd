using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Creador = "";
        public float Valor = 0;
        public int DiasAtraso = 0;
        private float Juros = 0.10f;


        public Fatura(string nomeDevedor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {
            Devedor = nomeDevedor;
            Creador = nomeEmpresa;
            Valor = valorFatura;
            DiasAtraso = qtdDiasAtraso;
        }

        public void CalcularValorDivida()
        {
            if (DiasAtraso > 0)
            {
                Valor = Valor + (DiasAtraso * Juros);
            }

            if (DiasAtraso >= 5)
            {
                Console.WriteLine($"Divida Encaminhada para o SERASA");
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Fatura...");
            Thread.Sleep(5000);

            Console.WriteLine($"Fatura Imprimida!");
            Console.WriteLine($"");
            CalcularValorDivida();
            Console.WriteLine(@$"
    Creador: {Creador}
    Devedor: {Devedor}
    Dias de Atraso: {DiasAtraso}
    Juros: {Juros + DiasAtraso}
    Valor Total: R${Valor}
            ");
        }
    }
}
