using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task1._1.LineEquation;

namespace task1._1
{
    internal class LineEquation
    {
        public double[] values;

        private double A;
        private double B;
        private double C;

        public LineEquation(double a, double b, double c)
        {
            A = a; 
            B = b; 
            C = c;

            values = new double[3] { a, b, c };
        }

        public double this[int index]
        {
            get => values[index];
            set => values[index] = value;
        }


        public Dot IntersectionDot(double a, double b, double c)
        {
            double x;
            double y;

            y = -c / (a * ((-B + -C) / A) + b);
            x = (-b * y + -c) / a;

            return new Dot(x, y); 
        }

        public Dot IntersectionDot(LineEquation line)
        {
            double x;
            double y;

            y = -line.C / (line.A * ((-B + -C) / A) + line.B);
            x = (-line.B * y + -line.C) / line.A;

            return new Dot(x, y);
        }

        public bool ContainsDot(double x, double y) => A * x + B * y + C == 0;

        public bool ContainsDot(Dot dot) => A * dot.x + B * dot.y + C == 0;

        public void PrintEquation() => Console.WriteLine($"{A}x + {B}y + c = 0");
    }
}
