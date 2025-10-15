using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class EmptyCalculationException:Exception
    {
        public EmptyCalculationException(string expression):base($"There has been an issue when calculating the expression:({expression}) ") { }
    }
}
