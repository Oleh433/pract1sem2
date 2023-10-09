namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TDisk disk = new TDisk(4,5,6);
            disk.ToString();
            Console.WriteLine(disk.GetArea());
            Console.WriteLine(disk.IsInCircle(3,0));
            TDisk disk2 = new TDisk();
            disk2.CopyTDisk(disk);
            disk2.ToString();

            TBall ball = new TBall(4,5,4,7);
            ball.GetArea();
        }
    }
}