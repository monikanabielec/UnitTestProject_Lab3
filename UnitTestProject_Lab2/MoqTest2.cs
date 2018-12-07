using System;
using Lab2_testy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;

namespace UnitTestProject_Lab2
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);
            var order = new Order();
            service.PlaceOrder(order);
            storage.Verify(s => s.Store(order), Times.Once);
        }


        [Test]
        public void TestOrderIdWhenObjectIsAdded
            ()
        {
            var storageMock = new Mock<IStorage>();
            storageMock.Setup(e => e.Store(1)).Returns(1);

            var order = new Order();

            Assert.True(order.Equals);
            

            //when false

            //_storageMock.Setup(s => s.Store(null)).Throws(new NullPointerException());
        }
    }
}
