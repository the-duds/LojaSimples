namespace LojaSimples.Application.Interfaces.Boundaries.Pedido
{
    public class ItemPedidoOutput
    {
        public ItemPedidoOutput(string response)
        {
            Result = response;
        }

        public string Result { get; private set; }
    }
}
