
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class CategoryCollection: ICategoryRepository
    {
        private List<Category> _categories;
        public CategoryCollection()
        {
            _categories= new List<Category>();
        }

        public void Create(Category category)
        {
            _categories.Add(category);
        }

        public Category GetCategoryById(int Id)
        {
            Category category = null;
            foreach (Category item in _categories)
            {
                if (item.Id == Id)
                {
                    category = item;
                    break;
                }
            }
            return category;
        }

        public IEnumerable<Category> List()
        { 
            return _categories;
        }

        public void Delete(Category category)
        {
            Category categoryForRemoval = _categories.Where(p => p.Id == category.Id).FirstOrDefault();
            _categories.Remove(category);
        }
        public Category Update(Category category)
        {
            foreach (var categoryItem in _categories)
            {
                if (category.Id == categoryItem.Id)
                {
                    categoryItem.Name = category.Name;
                    categoryItem.Description = category.Description;
                    break;
                }
            }
            return category;
        }
    }
}
