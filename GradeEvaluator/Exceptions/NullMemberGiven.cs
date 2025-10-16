using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Exceptions
{
    public class NullMemberGiven:Exception
    {
        public NullMemberGiven(string Message) : base(Message) { }
    }
}
