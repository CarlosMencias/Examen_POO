using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValueToPay()
        {
            return Price += Price * (decimal)Tax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Value............................:{GetValueToPay(),20:C2}";
        }
    }
}
