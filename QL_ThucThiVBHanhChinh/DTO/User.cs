using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DTO
{
    public class User
    {
        private string id;
        private string username;
        private string fullname;
        private string email;
        private string phone;
        private string position;
        private string idFaculty;
        private string role;
        private string password;
        private string status;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
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

        public string IdFaculty
        {
            get { return idFaculty; }
            set { idFaculty = value; }
        }

        public User(string id, string username, string fullname, string email, string phone, string position, string idFaculty, string role, string password, string status)
        {
            this.id = id;
            this.username = username;
            this.fullname = fullname;
            this.email = email;
            this.phone = phone;
            this.position = position;
            this.idFaculty = idFaculty;
            this.role = role;
            this.password = password;
            this.status = status;
        }

        public User() { }

        public User(User user)
        {
            this.id = user.id;
            this.username = user.username;
            this.fullname = user.fullname;
            this.email = user.email;
            this.phone = user.phone;
            this.position = user.position;
            this.idFaculty = user.idFaculty;
            this.role = user.role;
            this.password = user.password;
            this.status = user.status;
        }
        
        public bool equal(User user)
        {
            return (this.id == user.id && this.username == user.username && this.fullname == user.fullname &&
                this.email == user.email && this.phone == user.phone && this.position == user.position &&
                this.idFaculty == user.idFaculty && this.role == user.role && this.password == user.password &&
                this.status == user.status);
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
