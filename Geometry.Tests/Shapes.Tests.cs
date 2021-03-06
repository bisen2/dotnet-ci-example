using System;
using Xunit;

namespace Geometry.Tests
{

    public static class CustomAssert
    {
        public static void PlusOrMinus(double expected, double actual, double range) =>
            Assert.InRange(actual, expected - range, expected + range);
    }

    public class Circle_Tests
    {
        private double radius = 42;
        private Circle SUT;
        public Circle_Tests() => SUT = new Circle(radius);

        [Fact]
        public void Ctor_SetsRadius() => Assert.Equal(radius, SUT.Radius);

        [Fact]
        public void Ctor_SetsArea() => Assert.Equal(Math.PI * radius * radius, SUT.Area);

        [Fact]
        public void Ctor_SetsCircumference() => Assert.Equal(2 * Math.PI * radius, SUT.Circumference);
    }

    public class Rectangle_Tests
    {
        private double length = 27;
        private double width = 42;
        private Rectangle SUT;
        public Rectangle_Tests() => SUT = new Rectangle(length, width);

        [Fact]
        public void Ctor_SetsLength() => Assert.Equal(length, SUT.Length);

        [Fact]
        public void Ctor_SetsWidth() => Assert.Equal(width, SUT.Width);

        [Fact]
        public void Ctor_SetsArea() => Assert.Equal(length * width, SUT.Area);

        [Fact]
        public void Ctor_SetsCircumference() => Assert.Equal((2 * length) + (2 * width), SUT.Circumference);
    }

    public class Square_Tests
    {
        private double sideLength = 42;
        private Square SUT;
        public Square_Tests() => SUT = new Square(sideLength);

        [Fact]
        public void Ctor_SetsSideLength() => Assert.Equal(sideLength, SUT.SideLength);

        [Fact]
        public void Ctor_SetsNumSides() => Assert.Equal(4, SUT.NumSides);

        [Fact]
        public void Ctor_SetsArea() => CustomAssert.PlusOrMinus(sideLength * sideLength, SUT.Area, 0.001);

        [Fact]
        public void Ctor_SetsCircumference() => CustomAssert.PlusOrMinus(4 * sideLength, SUT.Circumference, 0.001);
    }

    public class Hexagon_Tests
    {
        private double sideLength = 42;
        private RegularHexagon SUT;
        public Hexagon_Tests() => SUT = new RegularHexagon(sideLength);

        [Fact]
        public void Ctor_SetsSideLength() => Assert.Equal(sideLength, SUT.SideLength);

        [Fact]
        public void Ctor_SetsArea()
        {
            double area = 3 * Math.Sqrt(3) * sideLength * sideLength / 2;
            CustomAssert.PlusOrMinus(area, SUT.Area, 0.001);
        }

        [Fact]
        public void Ctor_SetsCircumference() => CustomAssert.PlusOrMinus(6 * sideLength, SUT.Circumference, 0.001);
    }

    public class Octagon_Tests
    {
        private double sideLength = 42;
        private RegularOctagon SUT;
        public Octagon_Tests() => SUT = new RegularOctagon(sideLength);

        [Fact]
        public void Ctor_SetsSideLength() => Assert.Equal(sideLength, SUT.SideLength);

        [Fact]
        public void Ctor_SetsArea()
        {
            double area = 2 * sideLength * sideLength * (1 + Math.Sqrt(2));
            CustomAssert.PlusOrMinus(area, SUT.Area, 0.001);
        }

        [Fact]
        public void Ctor_SetsCircumference() => CustomAssert.PlusOrMinus(sideLength * 8, SUT.Circumference, 0.001);
    }
}
