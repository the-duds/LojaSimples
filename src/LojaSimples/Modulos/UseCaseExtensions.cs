using LojaSimples.Application.Interfaces.Boundaries.Pedido;
using LojaSimples.Application.Interfaces.Boundaries.Produto;
using LojaSimples.Application.Services.Pedido;
using LojaSimples.Application.Services.Produto;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaSimples.Modulos
{
    /// <summary>
    /// Registro de UseCase
    /// </summary>
    public static class UseCaseExtensions
    {
        /// <summary>
        /// Metodo chamado no startup para registrar os UseCase
        /// </summary>
        /// <param name="services">Serviço de UseCase</param>
        /// <returns></returns>
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IPedidoUseCase, PedidoUseCase>();

            services.AddScoped<IProdutoUseCase, ProdutoUseCase>();

          
            return services;
        }
    }
}
