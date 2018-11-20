using System.Collections.Generic;
using System.Linq;
using ApiDesign.Models;

namespace ApiDesign.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleltCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public List<Category> GetCategorys()
        {
            return _context.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            var categoryFromRepo = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            categoryFromRepo.Name = category.Name;
            categoryFromRepo.Description = category.Description;
            categoryFromRepo.ImgUrl = category.ImgUrl;

            _context.Categories.Update(categoryFromRepo);
            _context.SaveChanges();
        }
    }
}