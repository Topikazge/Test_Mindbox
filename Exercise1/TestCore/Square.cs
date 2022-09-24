using System;
using System.Collections.Generic;
using System.Text;
using Figur;

namespace TestCore
{
    public class FlatSquare : FigurBase
    {
        private double _sizeSide = 0;

        public FlatSquare(double sizeSide)
        {
            SizeSide = sizeSide;
        }

        /// <exception>
        /// В случай передачи отрицательного вызовет Exception
        /// </exception>
        public double SizeSide
        {
            set
            {
                if(_sizeSide >= 0)
                {
                    _sizeSide = value;
                }
                else
                {
                    throw new Exception("Длинна квадрата не может быть отрицательной!");
                }
            }
            get
            {
                return _sizeSide;
            }
        }

        public override double GetPerimeter()
        {
            return _perimeter;
        }

        public override double GetSquare()
        {
            _square = Math.Pow(_sizeSide,2); 
            return _square;
        }
    }
}
