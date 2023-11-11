using ShapeCalculation;

namespace AreaCalcTests
{
    public class UnitTest1
    {
        [Fact]
        public void AreaOfCircleWithREquals5Test()
        {
            //arrange
            double r = 5;
            //act
            var area = AreaCalculation.Circle(r);
            //assert
            Assert.Equal(Math.PI * r * r, area);
        }

        [Fact]
        public void AreaOfCircleWithInvalidRTest()
        {
            //arrange
            double r = -123.34d;
            //act
            var area = AreaCalculation.Circle(r);
            //assert
            Assert.Equal(-1, area);
        }

        [Fact]
        public void AreaOfTriangleWithSidesEqual2_2_3Test()
        {
            //arrange
            double side1 = 2;
            double side2 = 2;
            double side3 = 3;
            double exepted = 1.984313d;
            //act
            var area = AreaCalculation.Triangle(side1, side2, side3);
            //assert
            Assert.Equal(exepted, area,6);
        }

        [Fact]
        public void AreaOfTriangleWithSidesEqual450_470_854Test()
        {
            //arrange
            double side1 = 450;
            double side2 = 470;
            double side3 = 854;
            double exepted = 73034.410102d;
            //act
            var area = AreaCalculation.Triangle(side1, side2, side3);
            //assert
            Assert.Equal(exepted, area, 6);
        }

        [Fact]
        public void AreaOfTriangleWithSidesEqual450dot5674_470dot2234_854dot0001Test()
        {
            //arrange
            double side1 = 450.5674;
            double side2 = 470.2234;
            double side3 = 854.0001;
            double exepted = 73487.666851d;
            //act
            var area = AreaCalculation.Triangle(side1, side2, side3);
            //assert
            Assert.Equal(exepted, area, 6);
        }

        [Fact]
        public void AreaOfTriangleWithNoTriangleSidesTest()
        {
            //arrange
            double side1 = 100;
            double side2 = 100;
            double side3 = 600;
            double exepted = -1d;
            //act
            var area = AreaCalculation.Triangle(side1, side2, side3);
            //assert
            Assert.Equal(exepted, area, 6);
        }

        [Fact]
        public void AreaOfTriangleWithSidesLowerThanZeroTest()
        {
            //arrange
            double side1 = -100;
            double side2 = -100;
            double side3 = -600;
            double exepted = -1d;
            //act
            var area = AreaCalculation.Triangle(side1, side2, side3);
            //assert
            Assert.Equal(exepted, area, 6);
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            //arrange
            double side1 = 6;
            double side2 = 8;
            double side3 = 10;
            bool exepted = true;
            //act
            var isRight = ShapeCheck.IsRightTriangle(side1,side2,side3);
            //assert
            Assert.True(isRight);
        }

        [Fact]
        public void IsNotRightTriangleTest()
        {
            //arrange
            double side1 = 7;
            double side2 = 8;
            double side3 = 10;
            //act
            var isRight = ShapeCheck.IsRightTriangle(side1, side2, side3);
            //assert
            Assert.False(isRight);
        }
    }
}