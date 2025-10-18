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
        public Dictionary<Student, PachetAn> noteCatalog { get; set; }

        public Catalog()
        {
            noteCatalog = new();
        }

        public void AddSituatie(Student student, PachetAn  pachet)
        {
            if (student == null || pachet == null) throw new NullMemberGiven("Studentul trebuie sa contina informatii despre numele lui si materiile sale");
            if (noteCatalog.ContainsKey(student))   throw new StudentAlreadyExistsException();

            noteCatalog.Add(student, pachet);         
        }

        public string GetAverageGradesOfStudent(Student student)
        {
            string situatieFinala = string.Empty;

            if (!noteCatalog.ContainsKey(student)) throw new NonExistingStudentException(student.nume);

            situatieFinala = $"Studentul ({student.nume}) are urmatoarea situatie\n";
            foreach(var situatie in noteCatalog[student].materiiAn)
            {
                situatieFinala += situatie.PrettyString();
            }

            return situatieFinala;
        }

        public string GetAverageGradesForAllStudents()
        {
            string situatieFinala = "Situatie finala a mediei generale studentilor\n";
            

            foreach(var studenti in noteCatalog)
            {
                situatieFinala += $"({studenti.Key.nume}) in anul {studenti.Value.an} = ({GetAverageToAllMaterii(studenti.Value.materiiAn)})\n";
            }

            return situatieFinala;
        }

        public float GetAverageToAllMaterii(IList<Materie> materii)
        {
            float medieGenerala = 0f;
            foreach(var materie in materii)
            {
                medieGenerala += materie.GetAverageFromMaterie();
            }

            return medieGenerala / (materii.Count * 1.0f);
        }
    }
}
