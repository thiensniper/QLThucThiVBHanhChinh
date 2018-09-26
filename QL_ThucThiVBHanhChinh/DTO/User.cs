using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DTO
{
    public class User
    {
        private string username;
        private string fullname;
        private string email;
        private string role;
        private string password;
        private string status;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        public string Fullname
        {
            get
            {
                return fullname;
            }

            set
            {
                fullname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            
            set
            {
                status = value;
            }
        }

        public User(string username, string fullname, string email, string role, string password)
        {
            Username = username;
            Fullname = fullname;
            Email = email;
            Role = role;
            Password = password;
            Status = "true";
        }

        public override string ToString()
        {
            return "username: " + this.username
                + " fullname: " + this.fullname
                + " email: " + this.email
                + " role: " + this.role
                + " password: " + this.password
                + " status: " + this.status;
        }
    }
}
