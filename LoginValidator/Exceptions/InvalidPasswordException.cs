namespace LoginValidator.Exceptions
{
    [Serializable]
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string username):base($"The password provided for user ({username}) is invalid.")
        {
        }
    }
}