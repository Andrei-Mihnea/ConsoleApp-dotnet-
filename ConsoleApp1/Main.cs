namespace Exercitiul1
{

    public class MainClass
    {
        static void Main(string[] args)
        {
            Expression expression = new();
            Calculator calculator = new();

            Console.WriteLine("Introduceti expresia care doriti as fie calculata");
            expression.StringExpression = Console.ReadLine();
            calculator.CalculatorExpression = expression;


            calculator.Calculate();
        }
    }
}