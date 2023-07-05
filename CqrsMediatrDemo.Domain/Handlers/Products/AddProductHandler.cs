using CqrsMediatrDemo.Data;
using CqrsMediatrDemo.Domain.Commands.Products;
using MediatR;

namespace CqrsMediatrDemo.Domain.Handlers.Products
{
    public class AddProductHandler : IRequestHandler<AddProductCommand>
    {
        private readonly FakeDataStore _fakeDataStore;

        public AddProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            _fakeDataStore.Add(request.Product);
            return Task.CompletedTask;
        }
    }
}
