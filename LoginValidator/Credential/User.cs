using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginValidator.Credential
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; } = string.Empty;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
