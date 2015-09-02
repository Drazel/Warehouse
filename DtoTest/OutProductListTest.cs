using System;
using MongoDB.Bson;
using NUnit.Framework;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;

namespace DtoTest
{
    [TestFixture]
    public class OutProductListTest
    {
        private OrderPosition pos1 { get; set; }
        private OrderPosition pos2 { get; set; }
        private OrderPosition pos3 { get; set; }

        [SetUp]
        public void CreateData()
        {
            pos1 = new OrderPosition(1, "55ddaa59546c56237464705f", 2);
            pos2 = new OrderPosition(2, "55ddaa59546c56237464705f", 1);
            pos3 = new OrderPosition(3, "55ddaa59546c56237464705f", 3);
        }

        [Test]
        public void AddProductTest()
        {
            var outProductList = new OutProductList(DateTime.Now);
            outProductList.AddProduct(pos1);
            outProductList.AddProduct(pos2);
            outProductList.AddProduct(pos3);

            Assert.AreEqual(1, outProductList.Products.Count, "Za dużo elementów na liście");
            Assert.AreEqual(6, outProductList.Products[0].ProductCount, "Za duża ilość");
        }
    }
}
