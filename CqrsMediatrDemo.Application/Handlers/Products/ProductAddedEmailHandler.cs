using CqrsMediatrDemo.Application.Notifications.Products;
using CqrsMediatrDemo.Data;
using MediatR;

namespace CqrsMediatrDemo.Application.Handlers.Products
{
    public class ProductAddedEmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public ProductAddedEmailHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            _fakeDataStore.EventOccured(notification.Product, "Email enviado!");
            return Task.CompletedTask;
        }
    }
}
