using FireSharp.Response;
using QL_ThucThiVBHanhChinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DAO
{
    class UserDAO
    {
        private string urlUser = "/user";

        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private UserDAO() { }

        public async Task<List<User>> GetAllUsers()
        {
            List<User> list = new List<User>();
            FirebaseResponse response = await FirebaseConnection.Instance.Get(urlUser);
            dynamic obj = response.ResultAs<Dictionary<string, User>>();
            foreach(User data in obj.Values)
            {
                list.Add(data);
            }
            return list;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            FirebaseResponse response = await FirebaseConnection.Instance.Get(urlUser + "/" + username);
            return response.ResultAs<User>();
        }

        public async Task<bool> UpdateUser(User user)
        {
            SetResponse response = await FirebaseConnection.Instance.SetObject<User>(urlUser + "/" + user.Username, user);
            //await SetUsername(user, user.Fullname);
            if (response == null) return false;
            else return true;
        }

        public async Task<bool> DeleteUserByUsername(string username)
        {
            FirebaseResponse response = await FirebaseConnection.Instance.DeleteObject(urlUser + "/" + username);
            if (response == null) return false;
            else return true;
        }

        public async Task SetUsername(User user, string username) // Dùng để test role Firebase
        {
            SetResponse response = await FirebaseConnection.Instance.SetString(urlUser + "/" + user.Username + "/Username", username);
        }
    }
}
