using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NewsPortal.Logic
{
    public class NewsManager : BaseManager<News>
    {
        public NewsManager(NewsPortalDB db) : base(db)
        {
            
        }

        protected override DbSet<News> Table
        {
            get
            {
                return _db.News;
            }
        }

        public List<News> GetByTopic(int id)
        {
            return _db.News
                .Where(n => n.TopicId == id)
                .OrderByDescending(i => i.CreatedOn)
                .Take(10)
                .ToList();
        }

    }
}
