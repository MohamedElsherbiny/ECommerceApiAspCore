using System.Collections.Generic;
using System.Linq;
using ApiDesign.Models;

namespace ApiDesign.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context)
        {
            _context = context;

        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var OrderFromRepo = _context.Orders.FirstOrDefault(x => x.Id == id);
            if(OrderFromRepo != null)
                _context.Orders.Remove(OrderFromRepo);
        }

        public Order GetOrder(int id)
        {
            var OrderFromRepo = _context.Orders.FirstOrDefault(x => x.Id == id);
            if (OrderFromRepo != null)
            {
                return OrderFromRepo;
            }
            return null;
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public void UpdateOrder(Order order)
        {
            var OrderFromRepo = _context.Orders.FirstOrDefault(x => x.Id == order.Id);
            if (OrderFromRepo != null)
            {
                OrderFromRepo.Id = order.Id;
                OrderFromRepo.Name = order.Name;
                OrderFromRepo.City = order.City;
                OrderFromRepo.Country = order.Country;
                OrderFromRepo.State = order.State;
                OrderFromRepo.Zip = order.Zip;
                OrderFromRepo.Cart = order.Cart;
                _context.Orders.Update(OrderFromRepo);
                _context.SaveChanges();
            }
        }
    }
}