using FireSharp.Response;
using QL_ThucThiVBHanhChinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DAO
{
    class FacultyDAO
    {
        private string urlFaculty = "/faculty";

        private static FacultyDAO instance;

        internal static FacultyDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FacultyDAO();
                return instance;
            }
            private set => instance = value;
        }

        public FacultyDAO()
        {
        }

        public async Task<List<Faculty>> getAllFaculty()
        {
            List<Faculty> list = new List<Faculty>();
            FirebaseResponse response = await FirebaseConnection.Instance.Get(urlFaculty);
            dynamic obj = response.ResultAs<Dictionary<string, Faculty>>();
            foreach (Faculty data in obj.Values)
                list.Add(data);
            return list;
        }
    }
}
