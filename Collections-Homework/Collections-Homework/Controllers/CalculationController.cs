using Collections_Homework.Helpers.Extensions;
using Exceptions_Homework.Helpers.Exceptions;

namespace Exceptions_Homework.Controllers
{
    public class CalculationController
    {
        public void GetFactorial()
        {
			try
			{
				int number = -5;
                Console.WriteLine(number.FactorialOfNumber());
            }
			catch (CustomMathException ex)
			{
                Console.WriteLine(ex.Message);
            }
        }
    }
}
