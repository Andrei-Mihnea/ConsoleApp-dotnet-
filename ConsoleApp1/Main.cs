namespace Exercitiul1
{

    public class MainClass
    {
        static void Main(string[] args)
        {
            Expression expression = new();
            Calculator calculator = new();
            while (true)
            {
                Console.WriteLine("Introduceti expresia care doriti as fie calculata. If you want to exit the execution write stop");
                expression.StringExpression = Console.ReadLine();

                if (expression.StringExpression == "stop") break;

                calculator.CalculatorExpression = expression;
                calculator.Calculate();
            }
        }
    }
}