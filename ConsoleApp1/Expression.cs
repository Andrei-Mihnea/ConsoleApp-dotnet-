using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Exercitiul1
{
    public class Expression
    {
        public string StringExpression { get; set; } = string.Empty;

        private readonly string AllowedElementsInExpression = "+-*/()0987654321 ";

        public Expression(string expr)
        {
            if (String.IsNullOrEmpty(expr))
            {
                throw new ConsoleApp1.Exceptions.EmptyExpressionException();
            }

            var invalidCharacter = GetInvalidCharacter(expr);
            if (invalidCharacter != null)
            {
                throw new ConsoleApp1.Exceptions.InvalidExpressionException(expr,(char)invalidCharacter);
            }

            StringExpression = expr;
        }
        
        //checking if the given expression is valid
        public char? GetInvalidCharacter(string stringExpression)
        {
            for (int i = 0; i < stringExpression.Length; ++i)
            {
                if (!IsValidCharacter(stringExpression[i]))
                {
                    return stringExpression[i];
                }
            }
            return null;
        }
        


        //check if expression is valid and it's not something like : "24abd+21nda" ex.
        public bool IsValidCharacter(char character)
        { 
            return AllowedElementsInExpression.Contains(character);
        }


    }
}
