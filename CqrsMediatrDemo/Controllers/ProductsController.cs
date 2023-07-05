using CqrsMediatrDemo.Domain.Commands.Products;
using CqrsMediatrDemo.Domain.Queries.Products;
using CqrsMediatrDemo.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatrDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllProductsQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Product product)
        {
            await _mediator.Send(new AddProductCommand(product));
            return Ok(StatusCodes.Status201Created);
        }
    }
}
