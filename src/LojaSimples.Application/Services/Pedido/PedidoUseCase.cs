using LojaSimples.Application.Interfaces.Boundaries.Pedido;
using LojaSimples.Application.ViewModel;
using System.Threading.Tasks;

namespace LojaSimples.Application.Services.Pedido
{
    public class PedidoUseCase : IPedidoUseCase
    {
        private readonly IPedidoOutputPort _outputPort;
        public PedidoUseCase(IPedidoOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public async Task Execute(PedidoModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                if (true)
                {

                    _outputPort.Success(new PedidoOutput($""));
                    return;
                }

                
                _outputPort.WriteError("");
                return;
            }
            _outputPort.WriteError(input.Notifications);
        }
    }
}
