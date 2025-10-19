using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VerificatorAn.Exceptions;
using VerificatorAn.Manager;

namespace VerificatorAn.Helper
{
    public static class DateFormatValidation
    {
        public static bool IsValidYearFormat(this string date)
        {
            if (!date.Contains('/')) return false;

            IList<string> dateSplit = date.Split('/');

            if (dateSplit.Count == 0 || dateSplit.Count > 3) return false;
            if (!DateIsCorrectlyFormatted(dateSplit)) return false;

            return true;
        }

        public static IList<string> ReturnSplitString(this string date) => date.Split('/');


        public static IList<string> ReturnStringList(this DateTime date) =>
            new List<string> { date.Day.ToString("D2"), date.Month.ToString("D2"), date.Year.ToString() };

        private static bool DateIsCorrectlyFormatted(IList<string> date) =>
             date[0].Length == 2 && date[1].Length == 2 && date[2].Length == 4;


    }
}
