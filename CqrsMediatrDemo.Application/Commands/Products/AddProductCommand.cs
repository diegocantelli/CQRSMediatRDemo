using CqrsMediatrDemo.Domain;
using MediatR;

namespace CqrsMediatrDemo.Application.Commands.Products
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
    
}
