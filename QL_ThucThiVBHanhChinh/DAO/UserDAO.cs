﻿using FireSharp.Response;
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

        public async Task<List<User>> getUsers()
        {
            List<User> list = new List<User>();
            FirebaseResponse response = await DataProvider.Instance.Get(urlUser);
            dynamic obj = response.ResultAs<Dictionary<string, User>>();
            foreach(User data in obj.Values)
            {
                list.Add(data);
            }
            return list;
        }

        public async Task<bool> updateUser(User user)
        {
            SetResponse response = await DataProvider.Instance.SetObject<User>(urlUser + "/" + user.Username, user);
            //await setUsername(user, user.Fullname);
            if (response == null) return false;
            else return true;
        }

        public async Task setUsername(User user, string username) // Dùng để test role Firebase
        {
            SetResponse response = await DataProvider.Instance.SetString(urlUser + "/" + user.Username + "/Username", username);
        }
    }
}
