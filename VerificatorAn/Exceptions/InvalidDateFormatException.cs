using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificatorAn.Exceptions
{
    public class InvalidDateFormatException:Exception
    {
        public InvalidDateFormatException(string date):base($"Data pe care ai introdus-o ({date}) este una invalida.\n Formatul acceptat este dd/mm/yyyy") { }
    }
}
