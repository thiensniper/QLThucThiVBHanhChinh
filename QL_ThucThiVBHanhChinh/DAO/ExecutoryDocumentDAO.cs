using FireSharp.Response;
using QL_ThucThiVBHanhChinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DAO
{
    class ExecutoryDocumentDAO
    {
        private string urlDocument = "/ExecutoryDocument";

        private static ExecutoryDocumentDAO instance;

        public static ExecutoryDocumentDAO Instance { get => (instance == null) ? instance = new ExecutoryDocumentDAO() : instance; set => instance = value; }

        public ExecutoryDocumentDAO() { }

        public async Task<List<ExecutoryDocument>> getListExecutory()
        {
            FirebaseResponse response = await FirebaseConnection.Instance.Get(urlDocument + "/" + SessionInfo.user.Username);
            dynamic obj = response.ResultAs<Dictionary<string, ExecutoryDocument>>();
            List<ExecutoryDocument> list = new List<ExecutoryDocument>();
            foreach (ExecutoryDocument data in obj.Values)
                list.Add(data);
            return list;
        }
    }
}
