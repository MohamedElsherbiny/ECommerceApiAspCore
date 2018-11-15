using System.Collections.Generic;
using System.Linq;
using ApiDesign.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDesign.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return  _context.Products
                            .Include(x => x.Supplier)
                            .Include(x => x.Category)
                            .Include(x => x.Photos).ToList();
        }
    }
}