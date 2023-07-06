using CqrsMediatrDemo.Domain;
using MediatR;

namespace CqrsMediatrDemo.Application.Notifications.Products
{
    public record ProductAddedNotification(Product Product) : INotification;
}
