using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
{
    public class ItemManager
    {
        private List<Item> Items;

        public ItemManager()
        {
            Items = new List<Item>();
        }

        public List<Item> GetByCategory(int categoryId)
        {
            return Items.FindAll(i => i.CategoryId == categoryId);
        }

        public Item Create(Item item)
        {
            Items.Add(item);

            return item;
        }

        public void Update(Item item)
        {
            Item currentItem = Items.Find(i => i.Id == item.Id);
            // properties to update:
            currentItem.Price = item.Price;
            currentItem.Title = item.Title;
            currentItem.Description = item.Description;
            currentItem.Photo = item.Photo;
            currentItem.CategoryId = item.CategoryId;
        }

        public void Delete(int id)
        {
            Item item = Items.Find(i => i.Id == id);
            Items.Remove(item);
        }

        public Item Get(int id)
        {
            return Items.Find(i => i.Id == id);
        }
        public void Seed()
        {
            Items.Add(new Item()
            {
                Id = 1,
                Price = 10,
                Title = "Item 1",
                Description = "Desc 1",
                Photo = "Photo 1",
                CategoryId = 2
            }) ;

            Items.Add(new Item()
            {
                Id = 2,
                Price = 20,
                Title = "Item 2",
                Description = "Desc 2",
                Photo = "Photo 2",
                CategoryId = 2
            });
        }
    }
}
