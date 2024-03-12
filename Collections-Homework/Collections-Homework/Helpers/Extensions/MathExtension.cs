using Exceptions_Homework.Helpers.Exceptions;

namespace Collections_Homework.Helpers.Extensions
{
    public static class MathExtension
    {
        public static int FactorialOfNumber(this int number)
        {
            int result = 1;

            if (number < 0)
            {
                throw new CustomMathException("Number cannot be negative");
            }

            for (int i = 1; i < number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
