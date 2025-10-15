using System.Data;
using System.Linq.Expressions;

namespace Exercitiul1
{
    public class Calculator
    {
        public static string Calculate(Expression expression)
        {
            var result = new DataTable().Compute(expression.StringExpression, null)??throw new ConsoleApp1.Exceptions.EmptyCalculationException(expression.StringExpression);
            return $"{expression} = {result.ToString()}";
        }
    }
}
