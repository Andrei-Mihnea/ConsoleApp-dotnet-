using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LoginValidator.Interface;
using LoginValidator.Credential;
using LoginValidator.Exceptions;
using BCrypt.Net;

namespace LoginValidator.Database
{
    public class LocalRepository : IRepository
    {
        private readonly string jsonLocation = Path.Combine(AppContext.BaseDirectory, "localDb.json");
        public void AddUser(User user)
        {
            if (HasUser(user.username)) throw new UserAlreadyExistsException(user.username);

            var userRepositoryList = GetAllUsers();

            user.password = HashPassword(user.password);

            userRepositoryList.Add(user);

            var userRepositoryJson = JsonSerializer.Serialize(userRepositoryList);

            File.WriteAllText(jsonLocation, userRepositoryJson);
        }

        public bool HasUser(string username)
        {
            var userRepository = GetAllUsers();

            if (userRepository == null) throw new InexsistingDbException();

            return userRepository.Any(user => user.username == username);

        }

        public void RemoveUser(User user)
        {
            if (!HasUser(user.username)) throw new NoUserFoundException(user.username);

            var userRepositoryList = GetAllUsers();

            userRepositoryList.Remove(user);
        }

        public void UpdateUser(User user, string newUsername="", string newPassword="")
        {
            if (!HasUser(user.username)) throw new NoUserFoundException(user.username);

            var userRepositoryList = GetAllUsers();

            var existingUser = userRepositoryList.FirstOrDefault(u => u.username == user.username);

            if (existingUser == null) throw new NoUserFoundException(user.username);

            existingUser.username = newUsername!=null ? newUsername : user.username;
            existingUser.password = newPassword!=null ? newPassword : user.password;

            var SerializedJson = JsonSerializer.Serialize(user, new JsonSerializerOptions{ WriteIndented = true });

            File.WriteAllText(jsonLocation, SerializedJson);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool isPasswordValid(User user)
        {
            var userRepositoryList = GetAllUsers();
            var userFound = userRepositoryList.FirstOrDefault(u => u.username == user.username);

            if (userFound ==  null) throw new NoUserFoundException(user.username);
            if(!BCrypt.Net.BCrypt.Verify(user.password, userFound.password)) throw new InvalidPasswordException(user.username);
            return BCrypt.Net.BCrypt.Verify(user.password, userFound.password);
        }

        public IList<User> GetAllUsers()
        {
            if(!File.Exists(jsonLocation)) return new List<User>();

            var jsonUserContent = File.ReadAllText(jsonLocation);
            
            if(string.IsNullOrEmpty(jsonUserContent)) return new List<User>();
            
            return JsonSerializer.Deserialize<List<User>>(jsonUserContent) ?? new List<User>();
        }
    }
}
