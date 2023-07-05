using CqrsMediatrDemo.Domain;
using MediatR;

namespace CqrsMediatrDemo.Application.Queries.Products
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
