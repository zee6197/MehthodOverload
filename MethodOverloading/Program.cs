using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 21;
            var b = 29;
            var answer = TheAdd(a, b);

            var x = 35.0m;
            var y = 45.0m;
            var decimalAnswer = TheAdd(x, y);

            var thirdAnswer = TheAdd(0, 0, true);

            Console.WriteLine($"The int add is: {answer} The decimal add is: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }

        public static int TheAdd(int a, int b)
        {
            return a + b;
        }

        public static decimal TheAdd(decimal x, decimal y)
        {
            return x + y;
        }

        public static string TheAdd(int a, int b, bool condition)
        {
            if ((condition && a+b != 1) && (condition && a+b != -1))
            {
                return $"{a + b} dollars";
            }
            else if ((condition && a + b == 1) || (condition && a + b == -1))
            {
                return $"{a + b} dollar";
            }
            else
            {
                return $"{a + b}";
            }
        }
    }
}
