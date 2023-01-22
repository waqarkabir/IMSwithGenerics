using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>();
        }

        public void Create(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            foreach (var categoryItem in categories)
            {
                if (category.Id == categoryItem.Id)
                {
                    categories.Remove(categoryItem);
                    break;
                }
            }
        }

        public Category GetCategoryById(int Id)
        {
            Category category = null;
            foreach (var categoryItem in categories)
            {
                category = categoryItem;
                break;
            }
            return category;
        }

        public IEnumerable<Category> List()
        {
            return categories;
        }

        public Category Update(Category category)
        {
            foreach (var categoryItem in categories) 
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
