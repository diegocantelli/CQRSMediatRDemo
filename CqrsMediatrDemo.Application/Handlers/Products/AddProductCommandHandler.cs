using CqrsMediatrDemo.Application.Commands.Products;
using CqrsMediatrDemo.Data;
using CqrsMediatrDemo.Domain;
using MediatR;

namespace CqrsMediatrDemo.Application.Handlers.Products
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public AddProductCommandHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            _fakeDataStore.Add(request.Product);
            return Task.FromResult(request.Product);
        }
    }
}
