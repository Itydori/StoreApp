using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class OrderManager : IOrderService
    {
        private readonly IRepositoryManager _manager;

        public OrderManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IQueryable<Order> Orders => _manager.Order.Orders;

        public int NumberOfInProcess => _manager.Order.NumberOfInProcess;

        public void Complete(int OrderId)
        {
            _manager.Order.Complete(OrderId);
            _manager.Save();
        }

        public Order? GetOneOrder(int OrderId, bool trackChanges)
        {
            return _manager.Order.GetOneOrder(OrderId, trackChanges);
        }

        public void SaveOrder(Order order)
        {
            _manager.Order.SaveOrder(order);
        }
    }
}