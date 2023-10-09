using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class TBall : TDisk
    {
        protected int z;

        public TBall(int x, int y, int z, int radius) : base(x, y, radius)
        {
            this.z = z;
        }

        public override double GetArea() => 4 * Math.PI * Math.Pow(radius, 2);

        public override string ToString() => $"x = {x}, y = {y}, z = {z}, radius = {radius}";

        public double GetVolume() => 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

        public TBall Multiply(int number, TBall ball) => new TBall(ball.x, ball.y, ball.z, ball.radius * number);
        public TBall Multiply(TBall ball, int number) => new TBall(ball.x, ball.y, ball.z, ball.radius * number);
    }
}