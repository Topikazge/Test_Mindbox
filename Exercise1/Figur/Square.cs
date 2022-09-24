using System;
using System.Collections.Generic;
using System.Text;

namespace Figur
{
    public static class Square
    {
        /// <summary>
        /// Находит площадь круга через радиус.
        /// </summary>
        /// <returns>
        /// Площадь круга
        /// </returns>
        public static double Circle(double кadius)
        {
            return Math.PI * Math.Pow(кadius, 2);
        }

        /// <summary>
        /// Находит площадь треугольника через три стороны.
        /// </summary>
        /// <returns>
        /// Площадь Треугольника
        /// </returns>
        public static double Triangle(double firstSide, double secondSide, double thirdSide)
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }
    }
}
