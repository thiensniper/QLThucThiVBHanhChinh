using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DTO
{
    class User
    {
        private string username;
        private string fullname;
        private string email;
        private string role;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Email { get => email; set => email = value; }
        public string Role { get => role; set => role = value; }
        public string Password { get => password; set => password = value; }

        public User(string username, string fullname, string email, string role, string password)
        {
            Username = username;
            Fullname = fullname;
            Email = email;
            Role = role;
            Password = password;
        }

        public User( obj)
        {
            Username = obj.username;
        }
    }
}
