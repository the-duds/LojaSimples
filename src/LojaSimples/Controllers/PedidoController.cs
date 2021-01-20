using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentMediator;
using LojaSimples.Application.Interfaces.Boundaries.Pedido;
using LojaSimples.Application.ViewModel;
using LojaSimples.Models;
using LojaSimples.Presenter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaSimples.Controllers
{
    /// <summary>
    /// Controller responsavel por pedido.
    /// </summary>
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class PedidoController : ControllerBase
    {

        private readonly IMediator _mediator;

        /// <summary>
        /// Controller responsável por rotas relacionadas a Pedido.
        /// </summary>
        /// <param name="mediator">Interface de mediator para chamar os use case da aplicação.</param>
        public PedidoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Cadastra Pedido.
        /// </summary>
        /// <param name="pedido">Dados do pedido.</param>
        /// <param name="presenter">Presenter de Retorno.</param>
        /// <returns>Retorna resultado da operação.</returns>
        [HttpPost, Route("")]
        [ProducesResponseType(typeof(PedidoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostPedido(PedidoModel pedido, [FromServices] PedidoPresenter presenter)
        {
            await _mediator.PublishAsync(pedido).ConfigureAwait(false);

            return presenter.ViewModel;
        }

        /// <summary>
        /// Deleta Pedido.
        /// </summary>
        /// <param name="presenter">Presenter de Retorno.</param>
        /// <returns>Retorna resultado da operação.</returns>
        [HttpDelete, Route("{id}")]
        [ProducesResponseType(typeof(PedidoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletPedido(string id, [FromServices] PedidoPresenter presenter)
        {
            await _mediator.PublishAsync(null).ConfigureAwait(false);

            return presenter.ViewModel;
        }


        //// GET: api/<PedidoController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<PedidoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<PedidoController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<PedidoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PedidoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
