using CqrsMediatrDemo.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsMediatrDemo.Domain.Queries.Products
{
    public class GetAllProductsQuery : IRequest<IList<Product>>
    {
    }
}
