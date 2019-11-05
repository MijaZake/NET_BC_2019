using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Advertisements.Logic
{
    public class UserManager : BaseManager<User>
    {
        public UserManager(AdvertisementsDB db) : base(db)
        {

        }

        protected override DbSet<User> Table
        {
            get
            {
                return _db.Users;
            }
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return Table.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public User GetByEmail(string email)
        {
            return Table.FirstOrDefault(u => u.Email == email);
        }

        public void Seed()
        {
     
        }
    }
}
