using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IChair
    {
        string Name { get; set; }
        int Price { get; set; }
        void WhoCanSit();
    }

    public class VictorianChair : IChair
    {
        private string _name = "Victorian Chair";
        private int _price = 999;

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public void WhoCanSit()
        {
            Console.WriteLine("Only Noble can sit.");
        }
    }

    public class ModernChair : IChair
    {
        private string _name = "Modern Chair";
        private int _price = 10;

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public void WhoCanSit()
        {
            Console.WriteLine("Anyone can sit.");
        }
    }
}
