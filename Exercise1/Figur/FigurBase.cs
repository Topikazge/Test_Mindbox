using System;

namespace Figur
{
    public abstract class FigurBase
    {
        protected double _perimeter = 0;
        protected double _square = 0;

        public abstract double GetPerimeter();
        public abstract double GetSquare();
    }
}
