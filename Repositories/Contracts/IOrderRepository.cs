using Entities.Models;

namespace Repositories.Contracts
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        Order? GetOneOrder(int OrderId, bool trackChanges);
        void Complete(int OrderId);
        void SaveOrder(Order order);
        int NumberOfInProcess{get;}
    }
}