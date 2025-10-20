using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginValidator.Exceptions
{
    public class InvalidCommandException:Exception
    {
        public InvalidCommandException(string command) : base($"The command ({command}) is invalid. Please use a valid command.")
        {}
    }
}
