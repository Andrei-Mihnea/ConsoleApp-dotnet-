using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeEvaluator.Exceptions;

namespace GradeEvaluator
{
    public class PachetAn
    {
        public int an {  get; set; }
        public List<Materie> materiiAn;

        public PachetAn(int an)
        {
            this.an = an;
            materiiAn = new();
        }

        public void AddMaterieToPachetAn(Materie materie)
        {
            if (materie == null) throw new NullMemberGiven("Materia nu poate sa fie null");
            materiiAn.Add(materie);
        }
    }
}
