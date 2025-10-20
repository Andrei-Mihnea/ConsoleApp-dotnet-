using System.Runtime.Serialization;

namespace LoginValidator.Exceptions
{
    [Serializable]
    internal class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string user):base($"User with username {user} already exists. Try another username")  
        {
        }
    }
}