using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
{
    public class CategoryManager : BaseManager<Category>
    {
        public CategoryManager(WebShopDB db)
            : base(db)
            {

            }

        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }


        public void Seed()
        {

        }
    }
}
