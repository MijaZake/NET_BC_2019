using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisements.Logic
{
    public class CategoryManager
    {
        private List<Category> Categories;

        public CategoryManager()
        {
            Categories = new List<Category>();
        }

        public List<Category> GetAll()
        {
            return Categories;
        }

        public Category Get(int id)
        {
            return Categories.Find(c => c.Id == id);
        }

        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Category",
            });

            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Subcategory 1",
                CategoryId = 1
            });

            Categories.Add(new Category()
            {
                Id = 3,
                Title = "Subcategory 2",
                CategoryId = 1
            });

            Categories.Add(new Category()
            {
                Id = 4,
                Title = "Subcategory 3",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 5,
                Title = "Subcategory 4",
                CategoryId = 1
            });
        }
    }
    }
}
