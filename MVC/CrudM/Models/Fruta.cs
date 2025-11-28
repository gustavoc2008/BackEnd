using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudM.Models
{
    public class Fruta
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}
        public int Quantidade {get; set;}
        public string Categoria {get; set;}
        
    }
}