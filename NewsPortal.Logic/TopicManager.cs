using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NewsPortal.Logic
{
    public class TopicManager : BaseManager<Topic>
    {
        public TopicManager(NewsPortalDB db) : base(db)
        {

        }

        protected override DbSet<Topic> Table
        {
            get
            {
                return _db.Topics;
            }
        }

    }
}
