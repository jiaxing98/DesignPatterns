using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    //Use the Prototype pattern when your code shouldn’t depend
    //on the concrete classes of objects that you need to copy.

    //Use the pattern when you want to reduce the number of subclasses
    //that only differ in the way they initialize their respective
    //objects.Somebody could have created these subclasses to
    //be able to create objects with a specific configuration.

    public static class Main_Prototype
    {
        public static List<Shape> shapes = new List<Shape>();
        public static List<Shape> shapesCopy = new List<Shape>();
        
        public static void Init()
        {
            Circle circle = new Circle();
            circle.Color = "Orange";
            circle.Radius = 20;
            shapes.Add(circle);

            Rectangle rectangle = new Rectangle();
            rectangle.Color = "Blue";
            rectangle.Width = 10;
            rectangle.Length = 20;
            shapes.Add(rectangle);

            shapes.ForEach(x => shapesCopy.Add(x.Clone()));
            shapesCopy.ForEach(x => Console.WriteLine($"{x.Color} {x.GetType().Name}."));
        }
    }
}
