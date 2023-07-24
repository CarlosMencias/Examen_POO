using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public abstract class Product
    {
        public string? Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public override string ToString()
        {

            var Prec = Price * (decimal)0.9981;

            return $"{Id}\n\t" +
                   $"Description......................:{Description,20:C2}\n\t" +
                   $"Price............................:{Price,20:C2}\n\t" +
                   $"Tax..............................:{Tax,20:P0}\n\t";
        }

        public abstract decimal GetValueToPay();
    }
}
