using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESPL_POS;

namespace ESPL_POS_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRetrieveItemBySKU()
        {
            Product p = new Product();

            Product product = p.returnProductList("P123");

            Assert.AreEqual(9.90, product.Price);
            
        }

        [TestMethod]
        public void TestRetrieveNoValidSKU()
        {
            Product p = new Product();

            Product product = p.returnProductList("154");

            Assert.AreEqual(null, product.Price);

        }
    }
}
