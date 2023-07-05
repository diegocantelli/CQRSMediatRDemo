using CqrsMediatrDemo.Data;
using CqrsMediatrDemo.Domain.Queries.Products;
using CqrsMediatrDemo.Models;
using MediatR;

namespace CqrsMediatrDemo.Domain.Handlers.Products
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IList<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetAllProductsHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        
        public Task<IList<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_fakeDataStore.GetAll());
        }
    }
}
