using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESPL_POS;

namespace ESPL_POS_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product p = new Product();

            Product product = p.returnProductList("P123");

            Assert.AreEqual(9.90, product.Price);
            
        }
    }
}
