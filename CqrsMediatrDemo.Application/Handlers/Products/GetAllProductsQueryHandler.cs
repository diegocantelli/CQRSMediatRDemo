using CqrsMediatrDemo.Data;
using CqrsMediatrDemo.Domain;
using MediatR;

namespace CqrsMediatrDemo.Application.Handlers.Products
{
    public class GetAllProductsQueryHandler : IRequestHandler<Queries.Products.GetAllProductsQuery, IList<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetAllProductsQueryHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        
        public Task<IList<Product>> Handle(Queries.Products.GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_fakeDataStore.GetAll());
        }
    }
}
