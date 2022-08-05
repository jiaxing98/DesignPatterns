using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // The element interface declares an `accept` method that takes
    // the base visitor interface as an argument.
    public interface IShape
    {
        void Move(int x, int y);
        void Draw();
        void Accept(IVisitor v);
    }

    // Each concrete element class must implement the `accept`
    // method in such a way that it calls the visitor's method that
    // corresponds to the element's class.
    public class Dot : IShape
    {
        // Note that we're calling `visitDot`, which matches the
        // current class name. This way we let the visitor know the
        // class of the element it works with.

        public void Accept(IVisitor v)
        {
            v.VisitDot(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing {this.GetType().Name}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"{this.GetType().Name} moving to ({x}, {y}).");
        }
    }

    public class Circle : IShape
    {
        public void Accept(IVisitor v)
        {
            v.VisitCircle(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing {this.GetType().Name}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"{this.GetType().Name} moving to ({x}, {y}).");
        }
    }

    public class Rectangle : IShape
    {
        public void Accept(IVisitor v)
        {
            v.VisitRectangle(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing {this.GetType().Name}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"{this.GetType().Name} moving to ({x}, {y}).");
        }
    }

    public class CompoundShape : IShape
    {
        public void Accept(IVisitor v)
        {
            v.VisitCompoundShape(this);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing {this.GetType().Name}");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"{this.GetType().Name} moving to ({x}, {y}).");
        }
    }
}
