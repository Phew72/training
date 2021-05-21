using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public static string GetValueFor(int value)
        {
            if (NumberDivisibleBy(3, value) && 
                NumberDivisibleBy(5, value))
                return "FizzBuzz";

            if (NumberDivisibleBy(3, value))
                return "Fizz";

            if (NumberDivisibleBy(5, value))
                return "Buzz";

            return value.ToString();
        }

        public override string ToString()
        {
            var output = string.Empty;

            for (var i = 1; i <= 100; ++i)
            {
                output += GetValueFor(i) + ",";
            }

            return output.TrimEnd(',');
        }

        private static bool NumberDivisibleBy(int divisor, int value)
        {
            return value % divisor == 0;
        }
    }
}