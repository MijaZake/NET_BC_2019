using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.logic.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void TestGetByCategory()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();

            var allItems = manager.GetByCategory(2);

            Assert.AreEqual(2, allItems.Count);
        }

        [TestMethod]
        public void TestCreate()
        {
            ItemManager manager = new ItemManager();

            var item = manager.Create(new Item()
            {
                Id = 1,
                Price = 100,
                Title = "New Item",
                Description = "New description",
                Photo = "New Photo",
                CategoryId = 2
            });

            Assert.AreEqual(1, item.Id);
            Assert.AreEqual(100, item.Price);
            Assert.AreEqual("New Item", item.Title);
            Assert.AreEqual("New description", item.Description);
            Assert.AreEqual("New Photo", item.Photo);
            Assert.AreEqual(2, item.CategoryId);
            Assert.IsTrue(item.Id > 0);
        }

        [TestMethod]
        public void TestUpdate()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();
        }

        [TestMethod]
        public void TestDelete ()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();
        }

        [TestMethod]
        public void TestGet()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();
        }
    }
}
