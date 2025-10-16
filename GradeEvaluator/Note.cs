using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator
{
    public class Note
    {
        public List<int> note;

        public Note(List<int> note)
        {
            if (note.Count == 0) throw new NoGradesException();

            this.note = note;
        }

        public dobule GetAverageGrade()
        {
            double average = 0;
            foreach(var item in note)
            {
                average += item;
            }

            return average / (double) item.Count;
        }
    }
}
