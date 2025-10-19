using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificatorAn.Objects;

namespace VerificatorAn.Manager
{
    public class PublicHolidayManager
    {
        public IList<PublicHoliday> holidays;

        public PublicHolidayManager(IList<PublicHoliday> holidays)
        {
            this.holidays = holidays;
        }

        public void AddHoliday(PublicHoliday holiday)
        {
            holidays.Add(holiday);
        }

        public bool IsPublicHoliday(DateTime date)
        {
            foreach (var holiday in holidays)
            {
                if (holiday.CompareStringDateWithDateTime(date)) return true;
            }

            return false;
        }
    }
}
