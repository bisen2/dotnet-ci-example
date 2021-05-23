using System;

namespace Geometry
{

    public interface IShape
    {
        double Area { get; }
        double Circumference { get; }
    }

    public class Circle : IShape
    {
        public Circle(double radius) => Radius = radius;
        public double Radius { get; }
        public double Area => Math.PI * Radius * Radius;
        public double Circumference => 2 * Math.PI * Radius;
    }

    public class RegularPolygon : IShape
    {
        public RegularPolygon(int numSides, double sideLength)
        {
            NumSides = numSides;
            SideLength = sideLength;
        }
        public int NumSides { get; }
        public double SideLength { get; }
        public double Area => NumSides * SideLength * SideLength / Math.Tan(Math.PI / NumSides) / 4;
        public double Circumference => NumSides * SideLength;
    }

    public class Rectangle : IShape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Length { get; }
        public double Width { get; }
        public double Area => Length * Width;
        public double Circumference => 2 * Length + 2 * Width;
    }

    public class Square : RegularPolygon
    {
        public Square(double sideLength) : base(4, sideLength) { }
    }

    public class RegularHexagon : RegularPolygon
    {
        public RegularHexagon(double sideLength) : base(6, sideLength) { }
    }

    public class RegularOctagon : RegularPolygon
    {
        public RegularOctagon(double sideLength) : base(8, sideLength) { }
    }
}
