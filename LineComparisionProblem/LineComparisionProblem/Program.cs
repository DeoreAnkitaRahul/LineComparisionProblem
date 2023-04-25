using LineComparisionProblem;

namespace LineComparision
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateLength obj = new CalculateLength(20, 30, 40, 50);
            obj.Calculate();
            Console.ReadKey();
        }
    }
}