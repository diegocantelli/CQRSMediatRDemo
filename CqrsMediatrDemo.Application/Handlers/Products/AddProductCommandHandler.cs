using CqrsMediatrDemo.Application.Commands.Products;
using CqrsMediatrDemo.Data;
using MediatR;

namespace CqrsMediatrDemo.Application.Handlers.Products
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand>
    {
        private readonly FakeDataStore _fakeDataStore;

        public AddProductCommandHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            _fakeDataStore.Add(request.Product);
            return Task.CompletedTask;
        }
    }
}
