namespace task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineEquation n = new(1,-2,1);

            Console.WriteLine(n.IntersectionDot(1,3,-1));
            Console.WriteLine(n[0]);

            Console.WriteLine(n.ContainsDot(1, 1));
        }
    }
}