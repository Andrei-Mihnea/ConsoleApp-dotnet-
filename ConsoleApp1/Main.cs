namespace Exercitiul1
{

    public class MainClass
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Introduceti expresia care doriti as fie calculata. If you want to exit the execution write stop");
                    Expression expression = new(Console.ReadLine() ?? "");

                    if (expression.StringExpression == "stop") break;

                    Console.WriteLine(Calculator.Calculate(expression));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
        }
    }
}