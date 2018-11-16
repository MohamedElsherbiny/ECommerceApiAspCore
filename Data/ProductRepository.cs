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
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _context.Products.FirstOrDefault(x => x.Id == id);
            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                _context.SaveChanges();
            }

        }

        public Product GetProduct(int id)
        {
            return  _context.Products
                            .Include(x => x.Supplier)
                            .Include(x => x.Category)
                            .Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            return  _context.Products
                            .Include(x => x.Supplier)
                            .Include(x => x.Category)
                            .Include(x => x.Photos).ToList();
        }

        public void UpdateProduct(Product product)
        {
            var productFromRepo = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            if(productFromRepo != null)
            {
                productFromRepo.Name = product.Name;
                productFromRepo.Description = product.Description;
                productFromRepo.QuantityPerUnit = product.QuantityPerUnit;
                productFromRepo.UnitPrice = product.UnitPrice;
                productFromRepo.Top20 = product.Top20;
                productFromRepo.SupplierId = product.SupplierId;
                productFromRepo.CategoryId = product.CategoryId;

                _context.Products.Update(productFromRepo);
                _context.SaveChanges();
            }
        }
    }
}