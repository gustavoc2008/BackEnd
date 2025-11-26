using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        public static double PI = 3.14;

        public static float Somar(float x, float y)
        {
            return x + y;
        }

        public static float Subtrair(float x, float y)
        {
            return x - y;
        }

        public static float Multiplicar(float x, float y)
        {
            return x * y;
        }

        public static float Dividir(float x, float y)
        {
            if(x == 0 || y == 0)
            {
                return 0;
            }
            return x / y;
        }
    }
}