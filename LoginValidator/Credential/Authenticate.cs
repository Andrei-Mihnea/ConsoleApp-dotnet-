using LoginValidator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginValidator.Credential;
using LoginValidator.Exceptions;
using LoginValidator.Helper;
using System.Globalization;

namespace LoginValidator.Credential
{
    public static class Authenticate
    {
        public static void Register(IRepository UserRepository, string username, string password)
        {
            User user = new(username, password);
            UserRepository.AddUser(user);

            PromptHelper.Print($"User ({user.username}) has been succesfully registered");
        }

        public static void Login(IRepository UserRepository, string username, string password)
        {
            User user = new(username, password);

            if (UserRepository.isPasswordValid(user))
                PromptHelper.Print($"User ({user.username}) has been succesfully logged in\nSession closed.");

        }

        public static void InvalidCommand(string command) => throw new InvalidCommandException(command);
    }
}
