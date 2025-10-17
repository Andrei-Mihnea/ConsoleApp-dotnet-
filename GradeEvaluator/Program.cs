using GradeEvaluator.Testing;

namespace GradeEvaluator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while (true)
            {
                Console.WriteLine("Doriti sa continuati cu setul de date de test sau sa introduceti voi unul. " +
                    "Scrie test pentru setuul prestabilit sau input pentru unul personal");
                input = Console.ReadLine() ?? "";

                if (input.ToLower() == "test" || input.ToLower() == "input") break;
                Console.WriteLine($"Introdu o comanda valida. {input} nu este o comanda valida");

            }
            switch (input)
            {
                case "test":
                    {
                        try
                        {
                            InputTest.PredefinedTest();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"A intervernit o eroare! Eroare: {e.Message}");
                        }

                        break;
                    }
                case "input":
                    {
                        try
                        {
                            InputTest.UserInputTest();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"A intervernit o eroare! Eroare: {e.Message}");
                        }
                        break;
                    }


            }

        }


    }
}
