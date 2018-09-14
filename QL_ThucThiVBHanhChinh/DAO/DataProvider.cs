using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;
using Newtonsoft.Json;
using QL_ThucThiVBHanhChinh.DTO;

namespace QL_ThucThiVBHanhChinh.DAO
{
    class DataProvider
    {
        private HttpRequest httpClient;
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
            httpClient = new HttpRequest();
        }

        public string getString(string url)
        {
            try
            {
                return JsonConvert.ToString(httpClient.Get(url));
            }
            catch
            {
                return "Can't get data!";
            }
        }

        public Object getObjects(string url)
        {
            try
            {
                return JsonConvert.SerializeObject(new object());
            }
            catch
            {
                return null;
            }
        }
    }
}
