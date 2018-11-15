using System.Collections.Generic;
using ApiDesign.Models;

namespace ApiDesign.Data
{
    public interface IProductRepository
    {
         List<Product> GetProducts();
         Product GetProduct(int id);
         void AddProduct(Product product);
    }
}