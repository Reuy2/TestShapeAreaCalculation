using System.Collections.Immutable;

namespace ShapeCalculation
{
    public static class AreaCalculation
    {
        public static double Circle(double r)
        {
            if (r < 0) return -1;
            return Math.PI * r * r;
        }

        public static double Triangle(double firstSide, double secondSide,double thirdSide)
        {
            if(firstSide < 0 || secondSide < 0 || thirdSide < 0) return -1;

            if(!ShapeCheck.IsTriangle(firstSide, secondSide, thirdSide)) return -1;

            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;

            //Формула Герона.
            return Math.Sqrt(halfPerimeter * (halfPerimeter-firstSide)* (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        }
    }

    public static class ShapeCheck
    {
        public static bool IsRightTriangle(double firstSide, double secondSide, double thirdSide)
        {
            List<double> sides = new List<double> { firstSide, secondSide, thirdSide };
            sides.Sort();

            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }

        public static bool IsTriangle(double firstSide, double secondSide, double thirdSide)
        {
            List<double> sides = new List<double> { firstSide, secondSide, thirdSide };
            sides.Sort();

            return sides[0] + sides[1] > sides[2];
        }
    }
}