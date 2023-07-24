using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public class VariablePriceProduct : Product
    {
        public string? Measurement;
        public float Quantity;

        public override decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Measurement......................:{Measurement,20}\n\t" +
                   $"Quantity.........................:{Quantity,20}\n\t" +
                   $"Value............................:{GetValueToPay(),20:C2}\n\t";
        }
    }
}
