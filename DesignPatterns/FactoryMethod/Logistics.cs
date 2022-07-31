using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Abstract and Concrete Creator Class (The Factory)
    public abstract class Logistics
    {
        protected abstract ITransport CreateTransport();
        public void PlanDelivery(int fuel)
        {
            // Call the factory method to create a product object.
            ITransport transport = CreateTransport();

            // Now use the product.
            var enough = transport.IsFuelEnough(fuel);
            if(enough)
                transport.Deliver();
            else
                Console.WriteLine($"{transport.Name} don't have enough fuel to deliver.");
        }
    }

    public class RoadLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
    public class SeaLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }

}
