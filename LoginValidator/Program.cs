using LoginValidator.Credential;
using LoginValidator.Helper;
using LoginValidator.Interface;
namespace LoginValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository UserRepository = new Database.LocalRepository();

            while (true)
            {
                PromptHelper.Print("Welcome to Login Console App!\nChoose" +
                    " your options!\nType {login} to enter your account or {register} to register your account ");

                string input = Console.ReadLine() ?? string.Empty;
                input = input.Trim().ToLower();

                try
                {
                    switch (input)
                    {
                        case "register":
                            Authenticate.Register(UserRepository,
                                PromptHelper.Prompt("Insert your username you want to use for your account"),
                                PromptHelper.Prompt("Insert your password you want to use for your account")
                                );
                            break;

                        case "login":
                            Authenticate.Login(UserRepository,
                                PromptHelper.Prompt("Insert your username from your account"),
                                PromptHelper.Prompt("Insert your password")
                                );
                            Environment.Exit(0);
                            break;

                        default:
                            Authenticate.InvalidCommand(input);
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error has occured. Error: ({e.Message})");
                }
            }       
        }
    }
}
