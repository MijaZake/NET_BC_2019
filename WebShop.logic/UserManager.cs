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
        private int currentId;
        private static List<User> Users = new List<User>();


        public UserManager()
        {
            currentId = 1;
        }

        public User GetByEmailAndPassword(string email, string password)
        {
            return Users.Find(u => u.Email == email && u.Password == password);
        }

        public User Create(User user)
        {
            user.Id = currentId;
            Users.Add(user);
            currentId++;

            return user;
        }

        public User GetByEmail(string email)
        {
            return Users.Find(u => u.Email == email);
        }

        public void Delete(int id)
        {
            User user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }

        public void Update(User user)
        {
            User currentUser = Users.Find(u => u.Id == user.Id);
            // properties to update:
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;
        }

        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "1@email.com",
                Password = "Password1"
            });

            Users.Add(new User()
            {
                Id = 2,
                Email = "2@email.com",
                Password = "Password2"
            });
        }

    }
}
