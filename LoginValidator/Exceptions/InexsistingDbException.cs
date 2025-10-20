using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginValidator.Exceptions
{
    public class InexsistingDbException:Exception
    {
        public InexsistingDbException() : base("There is no database registered.") { }
    }
}
