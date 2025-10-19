using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Objects
{
    public class Student
    {
        public string nume {  get; set; } //nume prenume student

        public Student(string nume)
        {
            this.nume = nume;
        }
    }
}
