using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentMediator;
using LojaSimples.Application.Interfaces.Boundaries.Produto;
using LojaSimples.Application.ViewModel;
using LojaSimples.Models;
using LojaSimples.Presenter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaSimples.Controllers
{
    /// <summary>
    /// Controller responsavel por Produto
    /// </summary>
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Controller responsável por rotas relacionadas a Produto.
        /// </summary>
        /// <param name="mediator">Interface de mediator para chamar os use case da aplicação.</param>
        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Lista todos os Produto.
        /// </summary>
        /// <param name="presenter">Presenter de Retorno.</param>
        /// <returns>Retorna resultado da operação.</returns>
        [HttpGet, Route("all")]
        [ProducesResponseType(typeof(ProdutoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTudo([FromServices] ProdutoPresenter presenter)
        {
            await _mediator.PublishAsync(null).ConfigureAwait(false);

            return presenter.ViewModel;
        }

        /// <summary>
        /// Lista Produto por id.
        /// </summary>
        /// <param name="presenter">Presenter de Retorno.</param>
        /// <returns>Retorna resultado da operação.</returns>
        [HttpGet, Route("{id}")]
        [ProducesResponseType(typeof(ProdutoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTudo(string id ,[FromServices] ProdutoPresenter presenter)
        {

            await _mediator.PublishAsync(null).ConfigureAwait(false);

            return presenter.ViewModel;
        }




        /// <summary>
        /// Cadastra Produto.
        /// </summary>
        /// <param name="produto">Dados do produto.</param>
        /// <param name="presenter">Presenter de Retorno.</param>
        /// <returns>Retorna resultado da operação.</returns>
        [HttpPost, Route("")]
        [ProducesResponseType(typeof(ProdutoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostProduto(ProdutoModel produto, [FromServices] ProdutoPresenter presenter)
        {
            await _mediator.PublishAsync(produto).ConfigureAwait(false);

            return presenter.ViewModel;
        }


        /// <summary>
        /// Altera Produto.
        /// </summary>
        /// <param name="produto">Dados do produto.</param>
        /// <param name="presenter">Presenter de Retorno.</param>
        /// <returns>Retorna resultado da operação.</returns>
        [HttpPut, Route("")]
        [ProducesResponseType(typeof(ProdutoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutProduto(ProdutoModel produto, [FromServices] ProdutoPresenter presenter)
        {
            await _mediator.PublishAsync(produto).ConfigureAwait(false);

            return presenter.ViewModel;
        }

        
        /// <summary>
        /// Deleta Produto.
        /// </summary>
        /// <param name="presenter">Presenter de Retorno.</param>
        /// <returns>Retorna resultado da operação.</returns>
        [HttpDelete, Route("{id}")]
        [ProducesResponseType(typeof(ProdutoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletProduto(string id, [FromServices] ProdutoPresenter presenter)
        {
            await _mediator.PublishAsync(null).ConfigureAwait(false);

            return presenter.ViewModel;
        }


        //// GET: api/<ProdutoController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ProdutoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ProdutoController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProdutoController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProdutoController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
