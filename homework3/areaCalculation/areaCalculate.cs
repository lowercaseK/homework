using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace areaCalculation
{
    public class AreaCalculate
    {
        public double Triangle(double triLength,double triHeight)
        {
            double s = 0.5 * triHeight * triLength;
            return s;
        }
        public double Circle(double diameter)
        {
            double s = 3.1415926 * diameter * diameter/4;
            return s;
        }
        public double Square(double square)
        {
            double s = square * square;
            return s;
        }
        public double Rec(double recLength, double recWide)
        {
            double s = recLength * recWide;
            return s;
        }

    }
}
