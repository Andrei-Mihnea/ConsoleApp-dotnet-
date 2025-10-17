using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Exceptions
{
    public class StudentAlreadyExistsException:Exception
    {
        public StudentAlreadyExistsException() : base("Studentul deja este inrolat la universitate") {}
    }
}
