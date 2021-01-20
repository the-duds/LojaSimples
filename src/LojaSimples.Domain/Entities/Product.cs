using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSimples.Domain.Entities
{
    public class Product
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Value { get; set; }
    }
}
