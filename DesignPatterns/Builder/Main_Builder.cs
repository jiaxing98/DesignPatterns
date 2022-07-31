using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public static class Main_Builder
    {
        private static Director? _director;

        public static void Init()
        {
            _director = new Director();

            CarBuilder sportCarBuilder = new CarBuilder();
            _director.ConstructSportsCar(sportCarBuilder, "GTR");
            Car sportCar = sportCarBuilder.GetProduct();
            PrintInfo(sportCar);

            CarBuilder SUVBuilder = new CarBuilder();
            _director.ConstructSUV(SUVBuilder, "SUV");
            Car suv = SUVBuilder.GetProduct();
            PrintInfo(suv);
        }

        public static void PrintInfo(Car car)
        {
            Console.WriteLine($"Car {car.name} has created.");
            Console.WriteLine($"- {car.seats} seats.");
            Console.WriteLine($"- {car.engine} engine.");

            var hasGPS = car.hasGPS ? "- GPS is available." : $"- GPS is not available.";
            Console.WriteLine(hasGPS);
        }
    }
}
