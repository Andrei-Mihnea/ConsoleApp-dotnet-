using VerificatorAn.Manager;
using VerificatorAn.Objects;

namespace VerificatorAn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Public holiday set
            try
            {
                var holidays = new List<PublicHoliday>
                {
                    new PublicHoliday("New Year's Day", "01/01/2025"),
                    new PublicHoliday("Day after New Year", "02/01/2025"),
                    new PublicHoliday("Unification Day", "24/01/2025"),
                    new PublicHoliday("Good Friday", "18/04/2025"),
                    new PublicHoliday("Easter Sunday", "20/04/2025"),
                    new PublicHoliday("Easter Monday", "21/04/2025"),
                    new PublicHoliday("Labour Day", "01/05/2025"),
                    new PublicHoliday("Children's Day", "01/06/2025"),
                    new PublicHoliday("Pentecost", "08/06/2025"),
                    new PublicHoliday("Pentecost Monday", "09/06/2025"),
                    new PublicHoliday("Assumption of Mary", "15/08/2025"),
                    new PublicHoliday("St Andrew's Day", "30/11/2025"),
                    new PublicHoliday("National Day", "01/12/2025"),
                    new PublicHoliday("Christmas Day", "25/12/2025"),
                    new PublicHoliday("Second Day of Christmas", "26/12/2025")
                };

                var phm = new PublicHolidayManager(holidays);

                Year yearObject = new(2025);

                yearObject.GetNumberOfWorkDays(phm);

                Console.WriteLine(yearObject.GetObjInPrettyString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured. Error: ({ex.Message})");
            }

        }
    }
}
