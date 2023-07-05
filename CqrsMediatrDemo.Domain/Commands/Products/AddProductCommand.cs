using CqrsMediatrDemo.Models;
using MediatR;

namespace CqrsMediatrDemo.Domain.Commands.Products
{
    public record AddProductCommand(Product Product) : IRequest;
    
}
