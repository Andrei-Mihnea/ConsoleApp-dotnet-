using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificatorAn.Exceptions;
namespace VerificatorAn
{
    public class Year
    {
        public int year {  get; set; }
        public int days;
        public int numberOfWeeks;

        public Year(int year)  
        {
            if (year < 0) throw new NegativeYearException(year);

            this.year = year;
            days = year % 100 % 4 == 0 ? 366 : 365; //get number of days if the year is leap or not
            numberOfWeeks = days / 7;//set number of weeks
        }

        public bool IsLeap()
        {
            return days == 366;//checking if year is leap by days
        }
    }
}
