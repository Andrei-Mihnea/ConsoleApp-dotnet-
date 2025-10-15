using System.Data;
using System.Linq.Expressions;

namespace Exercitiul1
{
    public class Calculator
    {
        public Expression CalculatorExpression { get; set; } = new();


        public void Calculate()
        {
            try
            {
                if (!CalculatorExpression.IsValidExpression()) throw new Exception("Expresie invalida. Introduceti alta\n");

                var result = new DataTable().Compute(CalculatorExpression.StringExpression, null);
                Console.WriteLine($"{CalculatorExpression.StringExpression} = {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"A aparut o eroare.{e.Message}");
            }
        }
    }
}
