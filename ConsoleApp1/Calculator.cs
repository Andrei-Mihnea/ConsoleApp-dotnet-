using System.Data;
using System.Linq.Expressions;

namespace Exercitiul1
{
    public class Calculator
    {
        public Expression CalculatorExpression { get; set; }


        public void Calculate()
        {
            try
            {
                if (!CalculatorExpression.IsValidExpression()) throw new Exception("Invalid Expression given");

                var result = new DataTable().Compute(CalculatorExpression.stringExpression, null);
                Console.WriteLine($"{CalculatorExpression.stringExpression} = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"There has been an error.{e.Message}");
            }
        }
    }
}
