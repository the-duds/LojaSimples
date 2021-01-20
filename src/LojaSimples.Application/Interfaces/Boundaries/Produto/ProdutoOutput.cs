namespace LojaSimples.Application.Interfaces.Boundaries.Produto
{
    public class ProdutoOutput
    {
        public ProdutoOutput(string response)
        {
            Result = response;
        }

        public string Result { get; private set; }

    }
}
