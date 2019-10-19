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

            manager.Update(new Item() { 
            Id = 2,
            Price = 30,
            Title = "New Item",
            Description = "New description",
            Photo = "New Photo",
            CategoryId = 2
            });

            var item = manager.Get(2);

            Assert.AreEqual(2, item.Id);
            Assert.AreEqual(30, item.Price);
            Assert.AreEqual("New Item", item.Title);
            Assert.AreEqual("New description", item.Description);
            Assert.AreEqual("New Photo", item.Photo);
            Assert.AreEqual(2, item.CategoryId);
        }

        [TestMethod]
        public void TestDelete ()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();

            manager.Delete(1);

            var deletedItem = manager.Get(1);

            Assert.IsNull(deletedItem);
        }

        [TestMethod]
        public void TestGet()
        {
            ItemManager manager = new ItemManager();
            manager.Seed();

            var item1 = manager.Get(1);
            var item2 = manager.Get(2);
            var item3 = manager.Get(3);

            Assert.AreEqual(1, item1.Id);
            Assert.AreEqual(10, item1.Price);
            Assert.AreEqual("Item 1", item1.Title);
            Assert.AreEqual("Desc 1", item1.Description);
            Assert.AreEqual("Photo 1", item1.Photo);
            Assert.AreEqual(2, item1.CategoryId);

            Assert.AreEqual(2, item2.Id);
            Assert.AreEqual(20, item2.Price);
            Assert.AreEqual("Item 2", item2.Title);
            Assert.AreEqual("Desc 2", item2.Description);
            Assert.AreEqual("Photo 2", item2.Photo);
            Assert.AreEqual(2, item2.CategoryId);

            Assert.IsNull(item3);
        }
    }
}
