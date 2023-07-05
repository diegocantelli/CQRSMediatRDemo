using CqrsMediatrDemo.Models;
using MediatR;

namespace CqrsMediatrDemo.Domain.Queries.Products
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
