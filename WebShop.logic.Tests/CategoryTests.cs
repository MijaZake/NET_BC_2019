using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.logic.Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void TestGetAll()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();
            
            var result = manager.GetAll();

            Assert.AreEqual("Big category", result[0].Title);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void TestGet()
        {
            CategoryManager manager = new CategoryManager();
            manager.Seed();

            var category1 = manager.Get(1);
            var category2 = manager.Get(2);

            Assert.AreEqual(1, category1.Id);
            Assert.AreEqual("Big category", category1.Title);
            Assert.AreEqual(2, category2.Id);
            Assert.AreEqual("Small category", category2.Title);
            Assert.AreEqual(1, category2.CategoryId);
        }
    }
}
