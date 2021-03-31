using System;
using Xunit;

namespace Geometry.Tests {

    public class Circle_Tests {

        [Fact]
        public void Ctor_SetsRadius() {
            double radius = 42;
            var SUT = new Circle(radius);
            Assert.Equal(radius, SUT.Radius);
        }

        [Fact]
        public void Ctor_SetsArea() {
            double radius = 42;
            var SUT = new Circle(radius);
            Assert.Equal(Math.PI*radius*radius, SUT.Area);
        }

        [Fact]
        public void Ctor_SetsCircumference() {
            double radius = 42;
            var SUT = new Circle(42);
            Assert.Equal(2*Math.PI*radius, SUT.Circumference);
        }
    }

    public class Rectangle_Tests {

        [Fact]
        public void Ctor_SetsLength() {
            double length = 27;
            var SUT = new Rectangle(length, 0);
            Assert.Equal(length, SUT.Length);
        }

        [Fact]
        public void Ctor_SetsWidth() {
            double width = 42;
            var SUT = new Rectangle(0, width);
            Assert.Equal(width, SUT.Width);
        }

        [Fact]
        public void Ctor_SetsArea() {
            double length = 27;
            double width = 42;
            var SUT = new Rectangle(length, width);
            Assert.Equal(length * width, SUT.Area);
        }

        [Fact]
        public void Ctor_SetsCircumference() {
            double length = 27;
            double width = 42;
            var SUT = new Rectangle(length, width);
            Assert.Equal((2*length)+(2*width), SUT.Circumference);
        }
    }

    public class Square_Tests {
        [Fact]
        public void Ctor_SetsLengthAndWidth() {
            double length = 27;
            var SUT = new Square(length);
            Assert.Equal(length, SUT.Length);
            Assert.Equal(length, SUT.Width);
        }
    }

    public class Hexagon_Tests {

        [Fact]
        public void Ctor_SetsSideLength() {
            double length = 42;
            var SUT = new RegularHexagon(length);
            Assert.Equal(length, SUT.SideLength);
        }

        [Fact]
        public void Ctor_SetsArea() {
            double length = 42;
            var SUT = new RegularHexagon(length);
            double expected = 3 * Math.Sqrt(3) * length * length / 2;
            Assert.Equal(expected, SUT.Area);
        }

        [Fact]
        public void Ctor_SetsCircumference() {
            double length = 42;
            var SUT = new RegularHexagon(length);
            Assert.Equal(6 * length, SUT.Circumference);
        }
    }

    public class Octagon_Tests {
        private double sideLength = 42;
        private RegularOctagon SUT;
        public Octagon_Tests() => SUT = new RegularOctagon(sideLength);

        [Fact]
        public void Ctor_SetsSideLength() => Assert.Equal(sideLength, SUT.SideLength);

        [Fact]
        public void Ctor_SetsArea() {
            double area = 2 * sideLength * sideLength * (1 + Math.Sqrt(2));
            Assert.Equal(area, SUT.Area);
        }

        [Fact]
        public void Ctor_SetsCircumference() => Assert.Equal(sideLength * 8, SUT.Circumference);
    }
}
