using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSimples.Domain.Entities
{
    public class OrderItem
    {

        public Guid ProductID { get; set; }

        public decimal ProductValue { get; set; }

        public string ProductName { get; set; }

        public Guid OrderId { get; set; }
    }
}
