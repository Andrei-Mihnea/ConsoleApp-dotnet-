using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GradeEvaluator.Exceptions;
namespace GradeEvaluator
{
    public class Materie
    {
        public string nume {  get; set; }
        public string descriere {  get; set; }

        public Note noteMaterie { get; set; }

        public Materie(string materie, string descriere, Note noteMaterie)
        {
            if (materie == null || descriere == null) throw new NullMemberGiven("Trebuie oferit un nume si o descrierie materiei obligatoriu");
        
            this.nume = materie;
            this.descriere = descriere;
            this.noteMaterie = noteMaterie;
        }

        public float GetAverageFromMaterie()
        {
             return noteMaterie.GetAverageGrade();
        }

        public string PrettyString()
        {
            return $"Media la ({this.nume}) este de ({this.GetAverageFromMaterie()})\n";
        }

        public bool IsSameMaterie(string numeMaterie)
        {
            return this.nume == numeMaterie;
        }


    }
}
