using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QL_ThucThiVBHanhChinh.DTO;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using System.Windows.Forms;

namespace QL_ThucThiVBHanhChinh.DAO
{
    class FirebaseConnection
    {
        private string url = @"https://qlvbhc-90731.firebaseio.com"; // Firebase URL
        private IFirebaseConfig config;
        private IFirebaseClient client;

        private static FirebaseConnection instance;

        public static FirebaseConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new FirebaseConnection();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private FirebaseConnection()
        {
            config = new FirebaseConfig
            {
                BasePath = url
            };

            client = new FireSharp.FirebaseClient(config);
        }

        public async Task<FirebaseResponse> Get(string urlGet)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync(urlGet);
                return response;
            }
            catch(Exception message)
            {
                Console.WriteLine("\t ====Get() error:\n" + message.ToString());
                MessageBox.Show("Cannot get data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<SetResponse> SetObject<T>(string urlSet, T obj)
        {
            try
            {
                SetResponse response = await client.SetAsync(urlSet, obj);
                return response;
            }
            catch(Exception message)
            {
                Console.WriteLine("\t ====SetObject() error:\n" + message.ToString());
                MessageBox.Show("Cannot connect to server!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<FirebaseResponse> DeleteObject(string urlDelete)
        {
            try
            {
                FirebaseResponse response = await client.DeleteAsync(urlDelete);
                return response;
            }
            catch(Exception message)
            {
                Console.WriteLine("\t ====DeleteObject() error:\n" + message.ToString());
                MessageBox.Show("Cannot connect to server!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public async Task<SetResponse> SetString(string urlSet, string str)
        {
            try
            {
                SetResponse response = await client.SetAsync(urlSet, str);
                return response;
            }
            catch(Exception message)
            {
                Console.WriteLine("\t ====SetString() error:\n" + message.ToString());
                MessageBox.Show("Cannot connect to server!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
