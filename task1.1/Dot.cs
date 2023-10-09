using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._1
{
    public class Dot
    {
        public double x;
        public double y;

        public Dot(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public override string ToString()
        {
            return $"x = {x}, y = {y}";
        }
    }
}
