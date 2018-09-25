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
    class DataProvider
    {
        private string url = @"https://qlvbhc-90731.firebaseio.com"; // Firebase URL
        private IFirebaseConfig config;
        private IFirebaseClient client;

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DataProvider()
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
                MessageBox.Show("Cannot get data!\n" + message.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
