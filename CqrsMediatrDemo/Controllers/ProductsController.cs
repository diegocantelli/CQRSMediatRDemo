﻿using CqrsMediatrDemo.Application.Commands.Products;
using CqrsMediatrDemo.Application.Queries.Products;
using CqrsMediatrDemo.Domain;
using MediatR;
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

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllProductsQuery()));
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Product product)
        {
            await _mediator.Send(new AddProductCommand(product));
            return Ok(StatusCodes.Status201Created);
        }
    }
}
