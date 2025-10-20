using System.Runtime.Serialization;

namespace LoginValidator.Exceptions
{
    [Serializable]
    internal class NoUserFoundException : Exception
    {

        public NoUserFoundException(string user) : base($"User ({user}) not found in the database")
        {
        }

    }
}