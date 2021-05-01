using BusinessRulesEngine.DomainEntities;
using BusinessRulesEngine.Enums;
using BusinessRulesEngine.Products;
using BusinessRulesEngine.Service;
using NUnit.Framework;

namespace BusinessRulesEngineTest
{
    public class OrderProcessingServiceTests
    {
        const string PackingSlip = "Packing slip for shipping generated.";
        const string ComissionPayment = "Comssion payment to the agent generated.";
        const string DuplicateSlip = "Duplicate packing slip for royalty department created.";
        const string FreeVideo = "Added a free 'Free Aid' video to the packing slip.";
        readonly string MembershipUpgrade = "Upgraded to {0} membership.";
        readonly string MembershipActivate = "Activated {0} membership.";
        readonly string MembershipEmailUpgrade = "Email to owner informing about upgrade to {0} membership sent.";
        readonly string MembershipEmailActivate = "Email to owner informing about {0} membership activation sent.";
        readonly string ProcessForOther = "Did nothing for {0}.";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ProcessOrderForBook()
        {
            string productName = "Learn It";
            Product result = OrderProcessingService.ProcessOrder(ProductType.Book, productName);
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(3, result.ProcessingOperations.Count);
            Assert.AreEqual(PackingSlip, result.ProcessingOperations[0]);
            Assert.AreEqual(DuplicateSlip, result.ProcessingOperations[1]);
            Assert.AreEqual(ComissionPayment, result.ProcessingOperations[2]);
        }

        [Test]
        public void Test_ProcessOrderForMembershipActivation()
        {
            string productName = "Gold";
            Product result = new Membership(productName, "Activation");
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(2, result.ProcessingOperations.Count);
            Assert.AreEqual(string.Format(MembershipActivate, productName), result.ProcessingOperations[0]);
            Assert.AreEqual(string.Format(MembershipEmailActivate, productName), result.ProcessingOperations[1]);
        }

        [Test]
        public void Test_ProcessOrderForMembershipUpgrade()
        {
            string productName = "Premium";
            Product result = new Membership(productName, "Upgrade");
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(2, result.ProcessingOperations.Count);
            Assert.AreEqual(string.Format(MembershipUpgrade, productName), result.ProcessingOperations[0]);
            Assert.AreEqual(string.Format(MembershipEmailUpgrade, productName), result.ProcessingOperations[1]);
        }

        [Test]
        public void Test_ProcessOrderForMembershipTransaction()
        {
            string productName = "Diamond";
            Product result = new Membership(productName, " vdfvd ");
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(2, result.ProcessingOperations.Count);
            Assert.AreEqual(string.Format(MembershipActivate, productName), result.ProcessingOperations[0]);
            Assert.AreEqual(string.Format(MembershipEmailActivate, productName), result.ProcessingOperations[1]);
        }

        [Test]
        public void Test_ProcessOrderForVideo()
        {
            string productName = "Dance It";
            Product result = OrderProcessingService.ProcessOrder(ProductType.Video, productName);
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(2, result.ProcessingOperations.Count);
            Assert.AreEqual(PackingSlip, result.ProcessingOperations[0]);
            Assert.AreEqual(ComissionPayment, result.ProcessingOperations[1]);
        }

        [Test]
        public void Test_ProcessOrderForVideoSki()
        {
            string productName = "Learning to Ski";
            Product result = OrderProcessingService.ProcessOrder(ProductType.Video, productName);
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(3, result.ProcessingOperations.Count);
            Assert.AreEqual(PackingSlip, result.ProcessingOperations[0]);
            Assert.AreEqual(FreeVideo, result.ProcessingOperations[1]);
            Assert.AreEqual(ComissionPayment, result.ProcessingOperations[2]);
        }

        [Test]
        public void Test_ProcessOrderForOtherProduct()
        {
            string productName = "Cardboard";
            Product result = OrderProcessingService.ProcessOrder(ProductType.Other, productName);
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(1, result.ProcessingOperations.Count);
            Assert.AreEqual(string.Format(ProcessForOther, productName), result.ProcessingOperations[0]);
        }

        [Test]
        public void Test_ProcessOrderForUnknwonProduct()
        {
            string productName = "   fvdf  ";
            Product result = OrderProcessingService.ProcessOrder(ProductType.Other, productName);
            Assert.AreEqual(productName, result.ItemName);
            Assert.AreEqual(1, result.ProcessingOperations.Count);
            Assert.AreEqual(string.Format(ProcessForOther, productName), result.ProcessingOperations[0]);
        }
    }
}
