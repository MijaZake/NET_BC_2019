using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Advertisements.Logic
{
    public class CategoryManager : BaseManager<Category>
    {
        public CategoryManager(AdvertisementsDB db) : base(db)
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
