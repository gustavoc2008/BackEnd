using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cachorro : Animal
    {
        public void FazerSom()
        {
            Console.WriteLine($"AU AUAU AU!!!");
        }
    }
}