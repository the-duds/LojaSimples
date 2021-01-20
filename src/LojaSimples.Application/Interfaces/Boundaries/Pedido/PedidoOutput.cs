namespace LojaSimples.Application.Interfaces.Boundaries.Pedido
{
    public class PedidoOutput
    {
        public PedidoOutput(string response)
        {
            Result = response;
        }

        public string Result { get; private set; }
    }
}
