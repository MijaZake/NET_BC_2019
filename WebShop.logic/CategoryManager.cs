using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
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

        public int ItemCount(int categoryId)
        {
            var manager = new ItemManager();
            manager.Seed();
            List<Item> Items = manager.GetByCategory(categoryId);
            int count = Items.Count();

            return count;
        }

        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Big category",
            });

            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Small category",
                CategoryId = 1
            });
        }
    }
}
