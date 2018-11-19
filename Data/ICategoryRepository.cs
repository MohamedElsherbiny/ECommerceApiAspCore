using System.Collections.Generic;
using ApiDesign.Models;

namespace ApiDesign.Data
{
    public interface ICategoryRepository
    {
         List<Category> GetCategorys();
         Category GetCategory(int id);
         void AddCategory(Category category);
         void DeleltCategory(Category category);
         void UpdateCategory(Category category);
    }
}