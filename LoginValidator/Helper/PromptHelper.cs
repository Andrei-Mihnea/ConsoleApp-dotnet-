using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginValidator.Helper
{
    public static class PromptHelper
    {
        public static string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine() ?? string.Empty;  
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
