using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator
{
    public class Materie
    {
        public string materie {  get; set; }
        public string descriere {  get; set; }

        public Note noteMaterie { get; set; }

        public Materie(string materie, string descriere, Note noteMaterie)
        {
            if (materie == null || descriere == null) throw new NullMemberGiven("Trebuie oferit un nume materiei si descrierii obligatoriu");
        }

        public List<double> GetAverageFromMaterie()
        {
            List<double> medii;
            foreach(var note in noteMaterie.note)
            {
                medii.Add(note.GetAverageGrade());
            }

            return medii;
        }

    }
}
