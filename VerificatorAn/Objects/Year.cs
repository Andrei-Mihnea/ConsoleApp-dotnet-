using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificatorAn.Exceptions;
using VerificatorAn.Manager;
namespace VerificatorAn.Objects
{
    public class Year
    {
        public int year {  get; set; }
        public int days { get; set; }
        public int numberOfWeeks { get; set; }
        public int numberOfWorkDays { get; set; }

        public Year(int year)  
        {
            if (year < 0) throw new NegativeYearException(year);

            this.year = year;
            days = year % 100 % 4 == 0 ? 366 : 365; //get number of days if the year is leap or not
            numberOfWeeks = days / 7;//set number of weeks
            numberOfWorkDays = 0;
        }

        public string IsLeap()
        {
            return days == 366?"leap" :"not leap";//checking if year is leap by days
        }

        public void GetNumberOfWorkDays( PublicHolidayManager holidays)
        {
            DateTime start = new DateTime(this.year, 1, 1);
            DateTime end = new DateTime(this.year, 12, 31);

            for (var date = start; date <= end; date = date.AddDays(1))
            {
                bool isWeekday = date.DayOfWeek != DayOfWeek.Saturday &&
                                 date.DayOfWeek != DayOfWeek.Sunday;

                if (isWeekday && !holidays.IsPublicHoliday(date))
                    ++numberOfWorkDays;
            }

        }

        public string GetObjInPrettyString() => $"Year ({year}) with {days} days and is {IsLeap()} year\nHas {numberOfWeeks} weeks with {numberOfWorkDays} work days";


    }
}
