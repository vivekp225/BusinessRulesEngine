using BusinessRulesEngine.Enums;
using BusinessRulesEngine.Service;
using NUnit.Framework;

namespace BusinessRulesEngineTest
{
    public class ServiceHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_GetProductTypeAsBook()
        {
            Assert.AreEqual(ProductType.Book, ServiceHelper.GetProductType("book"));
        }

        [Test]
        public void Test_GetProductTypeAsMembership()
        {
            Assert.AreEqual(ProductType.Membership, ServiceHelper.GetProductType("MemBerSHip"));
        }

        [Test]
        public void Test_GetProductTypeAsVideo()
        {
            Assert.AreEqual(ProductType.Video, ServiceHelper.GetProductType("VIDEO"));
        }

        [Test]
        public void Test_GetProductTypeAsOther()
        {
            Assert.AreEqual(ProductType.Other, ServiceHelper.GetProductType("otheR"));
        }

        [Test]
        public void Test_GetProductTypeByUnknown()
        {
            Assert.AreEqual(ProductType.Other, ServiceHelper.GetProductType("dvedrfe4i4e8"));
        }

        [Test]
        public void Test_GetProductTypeByBlank()
        {
            Assert.AreEqual(ProductType.Other, ServiceHelper.GetProductType("   "));
        }
    }
}
