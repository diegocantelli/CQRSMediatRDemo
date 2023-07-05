using CqrsMediatrDemo.Domain;
using MediatR;

namespace CqrsMediatrDemo.Application.Queries.Products
{
    public class GetAllProductsQuery : IRequest<IList<Product>>
    {
    }
}
