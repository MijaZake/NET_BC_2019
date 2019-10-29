using System;
using System.Collections.Generic;
using System.Text;

namespace Advertisements.Logic
{
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

        public User GetByEmail(string email)
        {
            return Users.Find(u => u.Email == email);
        }

        public User Create(User user)
        {
            user.Id = currentId;
            Users.Add(user);
            currentId++;

            return user;
        }

        public void Delete(int id)
        {
            User user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }

        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "user1@email.com",
                Password = "1"
            });
            Users.Add(new User()
            {
                Id = 2,
                Email = "user1@email.com",
                Password = "2"
            });

        }
    }
}
