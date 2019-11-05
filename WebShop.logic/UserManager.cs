using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShop.logic
{
    /// <summary>
    /// Lietotaju menedzers
    /// </summary>
    public class UserManager : BaseManager<User>
    {
        public UserManager(WebShopDB db)
            : base(db)
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
            return _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public User GetByEmail(string email)
        {
            return _db.Users.FirstOrDefault(u => u.Email == email);
        }

        public void Seed()
        {
 
        }

    }
}
