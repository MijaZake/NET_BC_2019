using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Logic
{
    public class NewsPortalDB : DbContext
    {
        public NewsPortalDB(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<News> News { get; set; }
    }
}
