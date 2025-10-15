using System.Reflection.Metadata.Ecma335;

namespace Exercitiul1
{
    public class Expression
    {
        public string StringExpression { get; set; } = string.Empty;

        private readonly string AllowedElementsInExpression = "+-*/()0987654321";

        //checking if the given expression is valid
        public bool IsValidExpression()
        {
            for (int i = 0; i < StringExpression.Length; ++i)
            {
                if (!IsValidNumber(i))
                {
                    return false;
                }
            }
            return true;
        }

        //check if expression is valid and it's not something like : "24abd+21nda" ex.
        public bool IsValidNumber(int i)
        { 
            return AllowedElementsInExpression.Contains(StringExpression[i]);
        }
    }
}
