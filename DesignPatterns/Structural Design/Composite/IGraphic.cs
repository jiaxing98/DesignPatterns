using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // The component interface declares common operations for both
    // simple and complex objects of a composition.
    public interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
    }

    // The leaf class represents end objects of a composition. A
    // leaf object can't have any sub-objects. Usually, it's leaf
    // objects that do the actual work, while composite objects only
    // delegate to their sub-components.
    public class Dot : IGraphic
    {
        protected int x, y;

        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Draw a dot at ({x}, {y}).");
        }
    }

    // All component classes can extend other components.
    public class Circle : Dot
    {
        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw a circle at ({x}, {y}) with radius {_radius}.");
        }
    }
}
