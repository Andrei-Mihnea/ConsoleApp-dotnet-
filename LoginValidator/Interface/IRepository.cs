using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginValidator.Credential;

namespace LoginValidator.Interface
{
    public interface IRepository
    {
        public void AddUser(User user);
        public void RemoveUser(User user);
        public void UpdateUser(User user, string newUsername="", string newPassword="");
        public bool HasUser(string user);
        public bool isPasswordValid(User user);
        public string HashPassword(string password);
        public IList<User> GetAllUsers();
    }
}
