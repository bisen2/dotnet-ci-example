using System;

namespace Geometry {

    public interface IShape {
        double Area { get; }
        double Circumference { get; }
    }

    public class Circle : IShape {
        public Circle(double radius) => Radius = radius;
        public double Radius { get; }
        public double Area => Math.PI * Radius * Radius;
        public double Circumference => 2 * Math.PI * Radius;
    }

    public class Rectangle : IShape {
        public Rectangle(double length, double width) {
            Length = length;
            Width = width;
        }
        public double Length { get; }
        public double Width { get; }
        public double Area => Length * Width;
        public double Circumference => 2 * Length + 2 * Width;
    }

    public class Square : Rectangle {
        public Square(double length) : base(length, length) {}
    }

    public class RegularHexagon : IShape {
        public RegularHexagon(double sideLength) => SideLength = sideLength;
        public double SideLength { get; }
        public double Area => 3 * Math.Sqrt(3) * SideLength * SideLength / 2;
        public double Circumference => 6 * SideLength;
    }
}
