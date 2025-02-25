using Entities.Models;

namespace Services.Contracts
{
    public interface IOrderService
    {
        IQueryable<Order> Orders { get; }
        Order? GetOneOrder(int OrderId, bool trackChanges);
        void Complete(int OrderId);
        void SaveOrder(Order order);
        int NumberOfInProcess{get;}
        
    }
}