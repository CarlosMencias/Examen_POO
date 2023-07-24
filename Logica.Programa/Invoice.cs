using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Programa
{
    public class Invoice : IPay
    {
        private string? _products { get; set; }

        public decimal GetValueToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

