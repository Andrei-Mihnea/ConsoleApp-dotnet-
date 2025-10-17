using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Exceptions
{
    public class NonExistingStudentException:Exception
    {
        public NonExistingStudentException(string studentName) : base($"The student ({studentName}) isn't studying at this university ") { }
    }
}
