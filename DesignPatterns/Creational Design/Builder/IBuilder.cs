using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    // Builder Interface and Concrete Builder Class
    public interface IBuilder
    {
        string Name { get; set; }
        void Reset();
        void SetName(string name);
        void SetSeats(int number);
        void SetEngine(string engine);
        void SetGPS(bool value);
    }

    public class CarBuilder : IBuilder
    {
        private Car car;
        private string _name = "Car Builder";
        public string Name { get => _name; set => _name = value; }

        public CarBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.car = new Car();
        }

        public void SetName(string name)
        {
            car.name = name;
        }

        public void SetSeats(int numberOfSeats)
        {
            car.seats = numberOfSeats;
        }

        public void SetEngine(string engine)
        {
            car.engine = engine;
        }

        public void SetGPS(bool value)
        {
            car.hasGPS = value;
        }

        public Car GetProduct()
        {
            var product = this.car;
            this.Reset();
            return product;
        }
    }
}
