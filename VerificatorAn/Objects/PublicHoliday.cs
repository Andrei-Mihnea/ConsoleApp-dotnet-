using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificatorAn.Helper;
using VerificatorAn.Exceptions;

namespace VerificatorAn.Objects
{
    public class PublicHoliday
    {
        string name {  get; set; }
        public string date {  get; set; }

        public PublicHoliday(string name, string date)
        {
            if (!date.IsValidYearFormat()) throw new InvalidDateFormatException(date);

            this.name = name;
            this.date = date;
        }

        public bool CompareStringDateWithDateTime(DateTime date)
        {
            IList<string> DateSplit = date.ReturnStringList();
            IList<string> SplitString = this.date.ReturnSplitString();

            return DateSplit[0] == SplitString[0] && DateSplit[1] == SplitString[1] && DateSplit[2] == SplitString[2];
        }

        private void printDates(IList<string> dates)
        {
            foreach(var d in dates)
            {
                Console.Write($"{d} ");
            }

            Console.WriteLine("\n------------");
        }

    }
}
