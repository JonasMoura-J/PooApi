using System.Collections.Generic;
using MediatR;

namespace PooApi.Data.Domain.Shared
{
    public interface IAggregateRoot
    {
        ICollection<INotification> GetDomainEvents();
        void ClearDomainEvents();
    }
}
