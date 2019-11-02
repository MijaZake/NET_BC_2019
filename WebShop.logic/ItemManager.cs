using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
{
    public class ItemManager
    {
        WebShopDB _db;

        public ItemManager(WebShopDB db)
        {
           _db = db;
        }

        public List<Item> GetByCategory(int categoryId)
        {
            return _db.Items.Where(i => i.CategoryId == categoryId).ToList();
        }

        public Item Create(Item item)
        {
            _db.Add(item);
            _db.SaveChanges();

            return item;
        }

        public void Update(Item item)
        {
            Item currentItem = _db.Items.FirstOrDefault(i => i.Id == item.Id);
            // properties to update:
            currentItem.Price = item.Price;
            currentItem.Title = item.Title;
            currentItem.Description = item.Description;
            currentItem.Photo = item.Photo;
            currentItem.CategoryId = item.CategoryId;

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Item item = _db.Items.FirstOrDefault(i => i.Id == id);
            _db.Items.Remove(item);
        }

        public Item Get(int id)
        {
            return _db.Items.FirstOrDefault(i => i.Id == id);
        }
        public void Seed()
        {
          //Photo = "data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9InllcyI/PjxzdmcgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB3aWR0aD0iMjQyIiBoZWlnaHQ9IjIwMCIgdmlld0JveD0iMCAwIDI0MiAyMDAiIHByZXNlcnZlQXNwZWN0UmF0aW89Im5vbmUiPjwhLS0KU291cmNlIFVSTDogaG9sZGVyLmpzLzEwMCV4MjAwCkNyZWF0ZWQgd2l0aCBIb2xkZXIuanMgMi42LjAuCkxlYXJuIG1vcmUgYXQgaHR0cDovL2hvbGRlcmpzLmNvbQooYykgMjAxMi0yMDE1IEl2YW4gTWFsb3BpbnNreSAtIGh0dHA6Ly9pbXNreS5jbwotLT48ZGVmcz48c3R5bGUgdHlwZT0idGV4dC9jc3MiPjwhW0NEQVRBWyNob2xkZXJfMTY2OTUzZGI1ZWMgdGV4dCB7IGZpbGw6I0FBQUFBQTtmb250LXdlaWdodDpib2xkO2ZvbnQtZmFtaWx5OkFyaWFsLCBIZWx2ZXRpY2EsIE9wZW4gU2Fucywgc2Fucy1zZXJpZiwgbW9ub3NwYWNlO2ZvbnQtc2l6ZToxMnB0IH0gXV0+PC9zdHlsZT48L2RlZnM+PGcgaWQ9ImhvbGRlcl8xNjY5NTNkYjVlYyI+PHJlY3Qgd2lkdGg9IjI0MiIgaGVpZ2h0PSIyMDAiIGZpbGw9IiNFRUVFRUUiLz48Zz48dGV4dCB4PSI4OS44NTkzNzUiIHk9IjEwNS40Ij4yNDJ4MjAwPC90ZXh0PjwvZz48L2c+PC9zdmc+",
        }
    }
}
