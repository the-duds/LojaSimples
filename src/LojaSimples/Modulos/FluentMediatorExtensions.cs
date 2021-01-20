using FluentMediator;
using LojaSimples.Application.Interfaces.Boundaries.Pedido;
using LojaSimples.Application.Interfaces.Boundaries.Produto;
using LojaSimples.Application.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace LojaSimples.Modulos
{
    public static class FluentMediatorExtensions
    {
        /// <summary>
        /// Metodo chamado no startup para registrar o Mediator
        /// </summary>
        /// <param name="services">Serviço de Mediator</param>
        /// <returns></returns>
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddFluentMediator(
                builder =>
                {
                    builder.On<ProdutoModel>().PipelineAsync()
                       .Call<IProdutoUseCase>((handler, request) => handler.Execute(request));
                    builder.On<ItensPedidoModel>().PipelineAsync()
                       .Call<IItemPedidoUseCase>((handler, request) => handler.Execute(request));
                    builder.On<PedidoModel>().PipelineAsync()
                       .Call<IPedidoUseCase>((handler, request) => handler.Execute(request));

                });

            return services;
        }
    }
}
