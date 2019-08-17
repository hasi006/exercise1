using System;

namespace InterfaceTestability
{
    public class OrderProcessor
    {
        //private readonly ShippingCalculator _shippingCalculator;
        private readonly IShippingCalculator _shippingCalculator;//intrface allow to make loosely coupled 

        public OrderProcessor(IShippingCalculator shipingCaculator)
        {
            //this makes orderprocessor class tightly coupling with shipment calculator
            //if you need testing this coudnt able to perform isolated testing because of tightly coupeling
            //_shippingCalculator = new ShippingCalculator();
            _shippingCalculator = shipingCaculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
