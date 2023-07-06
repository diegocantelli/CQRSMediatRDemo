using CqrsMediatrDemo.Application.Notifications.Products;
using CqrsMediatrDemo.Data;
using MediatR;

namespace CqrsMediatrDemo.Application.Handlers
{
    public class CacheInvalidationHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public CacheInvalidationHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            _fakeDataStore.EventOccured(notification.Product, "Cache invalidated");
            return Task.CompletedTask;
        }
    }
}
