using CqrsMediatrDemo.Application.Queries.Products;
using CqrsMediatrDemo.Data;
using CqrsMediatrDemo.Domain;
using MediatR;

namespace CqrsMediatrDemo.Application.Handlers.Products
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetProductByIdQueryHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_fakeDataStore.GetById(request.id));
        }
    }
}
