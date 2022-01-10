
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace LABMediatR.Controllers
{
    using Requests;

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator) => _mediator = mediator;


        /// <summary>
        /// Lista os clientes cadastrados.
        /// </summary>        
        /// <returns>Retorna o estado da ação.</returns>
        /// <response code="200">Se for encontrado algum item.</response>
        /// <response code="500">Se ocorrer um erro no servidor.</response>
        [ProducesResponseType(typeof(IEnumerable<Domain.Customer>), 200)]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _mediator.Send(new GetAllRequest()).ConfigureAwait(false);
            if (!customers.Any())
                return NotFound();

            return Ok(customers);
        }


        /// <summary>
        /// Insere um novo Customer.
        /// </summary>
        /// <param name="product">Customer a ser adicionado.</param>
        /// <response code="200">Se o Customer for criado com sucesso.</response>
        /// <response code="400">Se a requisição não atender os requisitos mínimos.</response>
        /// <response code="404">Se o Customer informado não for encontrado.</response>
        /// <response code="500">Se ocorrer um erro no servidor.</response>
        [ProducesResponseType(typeof(InsertCustomerRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] InsertCustomerRequest customer) =>
             !ModelState.IsValid ? JsonResult(ModelState) : JsonResult(await _mediator.Send(customer));






    }
}
