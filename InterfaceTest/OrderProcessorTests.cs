using System;
using InterfaceTestability;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceTest
{
    [TestClass]
    public class OrderProcessorTests
    {

        //METHODNAME_CONDITION_EXCEPTION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_Orderisshipped_invalidoperationexception()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Id = 1,
                DatePlaced = DateTime.Now,
                Shipment = new Shipment {Cost=50,ShippingDate=DateTime.Now }
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_prcessorder_ordersuccessfull()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            var order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
