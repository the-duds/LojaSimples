using LojaSimples.Application.Interfaces.Boundaries.Produto;
using LojaSimples.Application.ViewModel;
using System.Threading.Tasks;

namespace LojaSimples.Application.Services.Produto
{
    public class ProdutoUseCase : IProdutoUseCase
    {
        private readonly IProdutoOutputPort _outputPort;
        public ProdutoUseCase(IProdutoOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public async Task Execute(ProdutoModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                if (true)
                {

                    _outputPort.Success(new ProdutoOutput($""));
                    return;
                }


                _outputPort.WriteError("");
                return;
            }
            _outputPort.WriteError(input.Notifications);
        }
    }
}
