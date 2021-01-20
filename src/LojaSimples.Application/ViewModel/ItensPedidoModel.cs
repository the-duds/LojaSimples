using System;

namespace LojaSimples.Application.ViewModel
{
    public class ItensPedidoModel
    {
        public string IdentificadorProduto { get; set; }

        public decimal ValorProduto { get; set; }

        public string NomeProduto { get; set; }

        public Guid IdentificadorPedido { get; set; }


    }
}
