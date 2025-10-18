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
        public IList<Materie> materiiAn;

        public PachetAn(int an, IList<Materie> materii)
        {
            this.an = an;
            materiiAn = materii;
        }

        public void AddMaterieToPachetAn(Materie materie)
        {
            if (materie == null) throw new NullMemberGiven("Materia nu poate sa fie null");
            materiiAn.Add(materie);
        }
    }
}
