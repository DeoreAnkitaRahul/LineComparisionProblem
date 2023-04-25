using LineComparisionProblem;

namespace LineComparision
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculateLength obj = new CalculateLength(20, 30, 40, 50);
            double length_One = obj.Calculate();

            CalculateLength obj_Two = new CalculateLength(40, 80, 60, 70);
            double length_Two = obj_Two.Calculate();

            if (length_One.Equals(length_Two))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Not equal");

            if (length_One.CompareTo(length_Two) == 0)
                Console.WriteLine("Both lines are equal");
            else if (length_One.CompareTo(length_Two) > 0)
                Console.WriteLine("Line one is greater than line two");
            else
                Console.WriteLine("Line Two is greater than line one");
            Console.ReadKey();
        }
    }
}