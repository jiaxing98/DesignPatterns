using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    //Base Prototype
    public abstract class Shape
    {
        private string? _color;
        public string Color { get => _color; set => _color = value; }

        public Shape() { }

        public Shape(Shape shape)
        {
            _color = shape._color;
        }

        public abstract Shape Clone();
    }

    //Concrete Prototype
    public class Rectangle : Shape
    {
        private int _width;
        public int Width { get => _width; set => _width = value; }
        private int _length;
        public int Length { get => _length; set => _length = value; }


        public Rectangle() { }

        public Rectangle(Rectangle source) : base(source)
        {
            _width = source._width;
            _length = source._length;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }

    //Concrete Prototype
    public class Circle : Shape
    {
        private int _radius;
        public int Radius { get => _radius; set => _radius = value; }

        public Circle() { }

        public Circle(Circle source) : base(source)
        {
            _radius = source._radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
