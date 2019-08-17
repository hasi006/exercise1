using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestability
{


    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            orderProcessor.Process(new Order { Id=1,DatePlaced= DateTime.Now,TotalPrice=2.50f});
        }
    }
}
