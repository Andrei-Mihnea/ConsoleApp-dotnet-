using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Exceptions
{
    public class NonExistingStudentException:Exception
    {
        public NonExistingStudentException(string studentName, string univerisityName) : base($"The student ({studentName}) isn't studying at the university ({univerisityName})") { }
    }
}
