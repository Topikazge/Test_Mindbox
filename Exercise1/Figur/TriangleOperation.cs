using System;
using System.Collections.Generic;
using System.Text;

namespace Figur
{
    public static class TriangleOperation
    {
        /// <summary>
        /// Проверяет равносторонний ли треугольник.
        /// </summary>
        public static bool isEquilateral(double firstCorner, double secondCorner, double thirdCorner)
        {
            firstCorner = Math.Abs(Math.Pow(firstCorner, 2));
            secondCorner = Math.Abs(Math.Pow(secondCorner, 2));
            thirdCorner = Math.Abs(Math.Pow(thirdCorner, 2));
            if ((firstCorner == (secondCorner + thirdCorner)) || (secondCorner == (firstCorner + thirdCorner)) || (thirdCorner == (secondCorner + firstCorner)))
            {
              return  true;
            }
            return false;
        }
    }
}
