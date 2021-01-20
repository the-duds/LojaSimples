using LojaSimples.Application.Interfaces.Boundaries.Pedido;
using LojaSimples.Application.Interfaces.Boundaries.Produto;
using LojaSimples.Presenter;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSimples.Modulos
{
    public static class PresenterExtensions
    {
        /// <summary>
        /// Metodo chamado no startup para registrar os Presenter
        /// </summary>
        /// <param name="services">Serviço de Presenter</param>
        /// <returns></returns>
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<PedidoPresenter, PedidoPresenter>();
            services.AddScoped<IPedidoOutputPort>(x => x.GetRequiredService<PedidoPresenter>());

            services.AddScoped<ItensPedidoPresenter, ItensPedidoPresenter>();
            services.AddScoped<IItemPedidoOutputPort>(x => x.GetRequiredService<ItensPedidoPresenter>());

            services.AddScoped<ProdutoPresenter, ProdutoPresenter>();
            services.AddScoped<IProdutoOutputPort>(x => x.GetRequiredService<ProdutoPresenter>());

            return services;
        }

    }
}
