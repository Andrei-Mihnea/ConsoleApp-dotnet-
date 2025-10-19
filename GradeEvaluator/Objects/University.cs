using GradeEvaluator.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Objects
{
    public class University
    {
        public string nume { get; set; } = string.Empty;

        Catalog catalog;

        public University(Catalog catalog, string nume)
        {
            if (catalog == null || nume == null) throw new NullMemberGiven("Catalogul si numele universitatii trebuie sa contina informatiile corespunzatoare obligatoriu");
            this.catalog = catalog;
        }

        public string GetAverageGradeForStudent(Student student)
        {
            return catalog.GetAverageGradesOfStudent(student);
        }

        public string GetAverageForAllStudents()
        {
            return catalog.GetAverageGradesForAllStudents();
        }
    }
}
