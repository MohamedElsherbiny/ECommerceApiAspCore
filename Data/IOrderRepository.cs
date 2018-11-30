using System.Collections.Generic;
using System.Threading.Tasks;
using ApiDesign.Models;

namespace ApiDesign.Data
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
         void AddOrder(Order order);
         void UpdateOrder(Order order);
         void DeleteOrder(int id);
    }
}