
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LABMediatR.Controllers
{
    using Requests;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
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

    }
}
