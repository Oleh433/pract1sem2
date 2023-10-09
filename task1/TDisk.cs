using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class TDisk
    {
        protected int radius;
        protected int x, y;

        public TDisk() => radius = 0;

        public TDisk(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public virtual double GetArea() => Math.PI * Math.Pow(radius, 2);

        public bool IsInCircle(int x, int y)
        {
            if (Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2)) > radius)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"x = {x}, y = {y}, radius = {radius}";
        }

        public void CopyTDisk(TDisk disk)
        {
            radius = disk.radius;
            x = disk.x;
            y = disk.y;
        }

        public TDisk Multiply(int number, TDisk disk) => new TDisk(disk.x, disk.y, disk.radius * number);
        public TDisk Multiply(TDisk disk, int number) => new TDisk(disk.x, disk.y, disk.radius * number);
    }
}
