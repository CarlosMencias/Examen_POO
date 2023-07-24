using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public class ComposedProduct : Product
    {
        public float Discount;
        public string? Products;


        public override decimal GetValueToPay()
        {
            return Price += Price * (decimal)Discount;
        }


        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                    $"Value............................:{GetValueToPay(),20:C2}\n";
        }
    }


}
