using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisements.Logic
{
    public class AdvertisementsDB : DbContext
    {
        public AdvertisementsDB(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
