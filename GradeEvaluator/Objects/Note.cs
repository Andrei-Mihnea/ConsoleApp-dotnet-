using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeEvaluator.Exceptions;
namespace GradeEvaluator.Objects
{
    public class Note
    {
        public IList<int> note;

        public Note(IList<int> note)
        {
            if (note.Count == 0) throw new NoGradesException();

            this.note = note;
        }

        public float GetAverageGrade()
        {
            float average = 0;

            foreach(var item in note)
            {
                average += item;
            }
            
            return average / (note.Count * 1.0f);//so we make it into float
        }
    }
}
