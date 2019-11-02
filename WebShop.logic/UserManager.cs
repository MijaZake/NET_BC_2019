using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.logic
{
    /// <summary>
    /// Lietotaju menedzers
    /// </summary>
    public class UserManager
    {
        private WebShopDB _db;


        public UserManager(WebShopDB db)
        {
            _db = db;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return _db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public User Create(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();

            return user;
        }

        public User GetByEmail(string email)
        {
            return _db.Users.FirstOrDefault(u => u.Email == email);
        }

        public void Delete(int id)
        {
            User user = _db.Users.FirstOrDefault(u => u.Id == id);
            _db.Users.Remove(user);
            _db.SaveChanges();
        }

        public void Update(User user)
        {
            User currentUser = _db.Users.FirstOrDefault(u => u.Id == user.Id);
            // properties to update:
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;
            _db.SaveChanges();
        }

        public void Seed()
        {
 
        }

    }
}
