using System.Reflection.Metadata.Ecma335;

namespace Exercitiul1
{
    public class Expression
    {
        public string StringExpression { get; set; }

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
            return (StringExpression[i] >= '0' && StringExpression[i] <= '9') ||
            StringExpression[i] == '(' || StringExpression[i] == ')' ||
            StringExpression[i] == ' ';
        }
    }
}
