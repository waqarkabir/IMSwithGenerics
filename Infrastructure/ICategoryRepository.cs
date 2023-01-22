using Entities;
using System.Collections.Generic;

namespace Infrastructure
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        IEnumerable<Category> List();

        Category? GetCategoryById(int Id);
        Category? Update(Category category);
        void Delete(Category category);
    }
}