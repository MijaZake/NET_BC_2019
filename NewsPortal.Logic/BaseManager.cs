using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortal.Logic
{
    public abstract class BaseManager<T> where T : BaseData
    {
        protected NewsPortalDB _db;
        protected abstract DbSet<T> Table { get; }

        public BaseManager(NewsPortalDB db)
        {
            _db = db;
        }

        public T Get(int id)
        {
            return Table.FirstOrDefault(i => i.Id == id);
        }

        public List<T> GetAll()
        {
            return Table.ToList();
        }
    }
}
