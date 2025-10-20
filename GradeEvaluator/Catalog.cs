using GradeEvaluator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator
{
    public class Catalog
    {
        public Dictionary<Student, List<Materie>> noteCatalog { get; set; }

        public int GetAverageGradesOfStudents(Student student)
        {
            if (!noteCatalog.ContainsKey(student)) throw new NonExistingStudentException(student.nume);

            
        }
    }
}
