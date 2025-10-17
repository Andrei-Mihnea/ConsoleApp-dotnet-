using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Exceptions
{
    public class NoGradesException:Exception
    {
        public NoGradesException() : base("Studentul trebuie sa aibe cel putin o nota trecuta pentru calcularea mediei")
        { }
    }
}
