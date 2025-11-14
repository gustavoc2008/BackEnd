using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ExerciciosPolimorfismo
{
    public abstract class Pagamento
    {
        public abstract float calcularTotal();
    }
}