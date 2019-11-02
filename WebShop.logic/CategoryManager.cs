using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
{
    public class CategoryManager
    {
        WebShopDB _db;

        public CategoryManager(WebShopDB db)
        {
            _db = db;
        }
        public List<Category> GetAll()
        {
            return _db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return _db.Categories.FirstOrDefault(c => c.Id == id);
        }

        public void Seed()
        {
           
        }
    }
}
