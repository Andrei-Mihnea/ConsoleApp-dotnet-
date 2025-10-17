namespace VerificatorAn.Exceptions
{
    internal class NegativeYearException : Exception
    {
        public NegativeYearException(int year):base($"Introduce a valid year. The year ({year}) is not valid")
        {
        }

    }
}