using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPolimorfismo
{
    public class PagamentoCartao : Pagamento
    {
        private float acrescimo = 5.38f;
        public float valorCompra;
        public override float calcularTotal()
        {
            float valorAcrescimo = valorCompra / 100 * acrescimo;

            return valorCompra = valorCompra + valorAcrescimo;
        }  
    }
}