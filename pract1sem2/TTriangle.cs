using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1sem2
{
    class TTriangle
    {
        protected double _side1, _side2, _side3;

        public double Side1
        {
            get => _side1;
            set
            {
                if (IsCorrect(value, _side2, _side3))
                {
                    _side1 = value;
                }
            }
        }

        public double Side2
        {
            get => _side2;
            set
            {
                if (IsCorrect(_side1, value, _side3))
                {
                    _side2 = value;
                }
            }
        }

        public double Side3
        {
            get => _side3;
            set
            {
                if (IsCorrect(_side1, _side2, value))
                {
                    _side3 = value;
                }
            }
        }

        public TTriangle(double side1, double side2, double side3)
        {
            if (!IsCorrect(side1, side2, side3))
            {
                throw new ArgumentException();
            }
            _side1 = side1;
            _side2 = side3;
            _side3 = side3;
        }

        private bool IsCorrect(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3 && side1 + side3 > side2 && side3 + side2 > side1);
        }

        public double GetPerimeter() => _side1 + _side2 + _side3;

        public double GetArea()
        {
            double p = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }
    }

}
