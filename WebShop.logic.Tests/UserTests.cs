using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.logic.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestGetByEmailAndPassword()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            var user1 = manager.GetByEmailAndPassword("1@email.com", "Password1");
            var user2 = manager.GetByEmailAndPassword("2@email.com", "Password2");
            var user3 = manager.GetByEmailAndPassword("3@email.com", "Password3");

            Assert.AreEqual("1@email.com", user1.Email);
            Assert.AreEqual("Password1", user1.Password);
            Assert.AreEqual("2@email.com", user2.Email);
            Assert.AreEqual("Password2", user2.Password);
            Assert.IsNull(user3);
        }

        [TestMethod]
        public void TestCreate()
        {
            UserManager manager = new UserManager();
            User user = manager.Create(new User()
            { 
            Email = "new@email.com",
            Password = "newPassword"
            });

            Assert.AreEqual("new@email.com", user.Email);
            Assert.AreEqual("newPassword", user.Password);
            Assert.IsTrue(user.Id > 0);
        }

        [TestMethod]
        public void TestGetByEmail()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            var user1 = manager.GetByEmail("1@email.com");
            var user2 = manager.GetByEmail("2@email.com");
            var user3 = manager.GetByEmail("3@email.com");

            Assert.AreEqual("1@email.com", user1.Email);
            Assert.AreEqual("2@email.com", user2.Email);
            Assert.IsNull(user3);
        }

        [TestMethod]
        public void TestDelete()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Delete(1);

            var deletedUser = manager.GetByEmail("1@email.com");

            Assert.IsNull(deletedUser);
        }

        [TestMethod]
        public void TestUpdate()
        {
            UserManager manager = new UserManager();
            manager.Seed();

            manager.Update(new User()
            {
                Id = 2,
                Email = "new2@email.com"
            });

            var user = manager.GetByEmail("new2@email.com");

            Assert.AreEqual(2, user.Id);
            Assert.AreEqual("new2@email.com", user.Email);
        }
    }
}
