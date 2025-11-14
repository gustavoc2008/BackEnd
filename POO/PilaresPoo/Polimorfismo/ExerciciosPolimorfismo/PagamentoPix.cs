using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPolimorfismo
{
    public class PagamentoPix : Pagamento
    {
        private float desconto = 5;
        public float valorCompra;
        public override float calcularTotal()
        {
            float valorDesconto = valorCompra / 100 * desconto;
            return valorCompra = valorCompra - valorDesconto;
        }
    }
}