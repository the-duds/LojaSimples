using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSimples.Domain.Entities
{
    public class Order
    {

        public decimal TotalValue { get; set; }
        public string Cpf { get; set; }
        public List<OrderItem> Itens { get; set; }
    }
}
