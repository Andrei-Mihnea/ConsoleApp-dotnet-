using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class InvalidExpressionException:Exception
    {
        public InvalidExpressionException() { }
        public InvalidExpressionException(string expression, char invalidCharacter) : base($"({expression}) has invalid character: ({invalidCharacter})")
        {

        }

    }
}
