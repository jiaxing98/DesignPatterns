using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Use the Abstract Factory when your code needs to work with various
    //families of related products, but your don't want it to depend on the
    //concrete classes of those products - they might be unknown beforehand
    //or you simply want to allow for future extensibility

    public static class Main_AbstractFactory
    {
        private static IFurnitureFactory? _furnitureFactory;
        private static IChair? _chair;

        public static void Init(IFurnitureFactory furnitureFactory)
        {
            _furnitureFactory = furnitureFactory;
            _chair = _furnitureFactory.CreateChair();
            
            Console.WriteLine($"The price of the {_chair.Name} is {_chair.Price}.");
            _chair.WhoCanSit();
        }
    }
}
