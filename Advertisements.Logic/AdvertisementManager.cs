using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Advertisements.Logic
{
    public class AdvertisementManager : BaseManager<Advertisement>
    {
        public AdvertisementManager(AdvertisementsDB db) : base(db)
        {
            
        }

        protected override DbSet<Advertisement> Table
        {
            get
            {
                return _db.Advertisements;
            }
        }

        public List<Advertisement> GetByCategory(int categoryId)
        {
            return _db.Advertisements.Where(a => a.CategoryId == categoryId).ToList();
        }

        public void Seed()
        {
          
        }
    }
}
