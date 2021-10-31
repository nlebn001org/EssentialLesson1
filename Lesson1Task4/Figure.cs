using System;

namespace Lesson1Task4
{
    class Figure
    {

        public string FigureName { get; }
        public double Perimeter { get; }                        // INSTEAD OF "void PerimeterCalculator()" METHOD

        public Figure(Point p1, Point p2, Point p3)
        {
            FigureName = "Triangle";
            Perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            FigureName = "Rectangle";
            Perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            FigureName = "Pentagon";
            Perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
        }


        private double LengthSide(Point A, Point B)
        {
            double diffA = A.Int2 - A.Int1;
            double diffB = B.Int2 - B.Int1;
            double sum = Math.Pow(diffA, 2) + Math.Pow(diffB, 2);
            double lengthSide = Math.Sqrt(sum);

            return Math.Round(lengthSide);
        }
    }
}
