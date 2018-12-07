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
            Mock<IStorage> _storageMock = new Mock<IStorage>();
            var _order = new Order();
            var _service = new OrderService(_storageMock.Object);
            _storageMock.Setup(m => m.Store(2).CompareTo(2));
            

            //when false

            //_storageMock.Setup(s => s.Store(null)).Throws(new NullPointerException());
        }
    }
}
