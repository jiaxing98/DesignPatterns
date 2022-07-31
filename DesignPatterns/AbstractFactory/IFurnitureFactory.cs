using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract Factory Interface and Concrete Factory Class
    /// </summary>
    public interface IFurnitureFactory
    {
        IChair CreateChair();
    }

    public class VictorainFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }
    }

    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
    }
}
