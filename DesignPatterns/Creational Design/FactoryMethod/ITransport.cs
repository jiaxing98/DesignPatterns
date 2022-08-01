using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Product Interface and Concrete Product Class
    public interface ITransport
    {
        string Name { get; set; }
        void Deliver();
        bool IsFuelEnough(int amount);
    }

    public class Truck : ITransport
    {
        private int fuel = 10;
        private string _name = "Truck";
        public string Name { get => _name; set => _name = value; }

        public void Deliver()
        {
            Console.WriteLine("Truck is delivering the product.");
        }

        public bool IsFuelEnough(int amount)
        {
            return amount > fuel;
        }
    }

    public class Ship : ITransport
    {
        private int fuel = 5;
        private string _name = "Ship";
        public string Name { get => _name; set => _name = value; }

        public void Deliver()
        {
            Console.WriteLine("Ship is delivering the product.");
        }

        public bool IsFuelEnough(int amount)
        {
            return amount > fuel;
        }
    }
}
