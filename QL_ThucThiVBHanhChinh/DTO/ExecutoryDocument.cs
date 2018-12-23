using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DTO
{
    class ExecutoryDocument
    {
        private string dateCreate;
        private string dateRemind;
        private string description;
        private string idDocumentary;
        private string title;
        private string involvedUser;

        public string DateCreate { get => dateCreate; set => dateCreate = value; }
        public string DateRemind { get => dateRemind; set => dateRemind = value; }
        public string Description { get => description; set => description = value; }
        public string IdDocumentary { get => idDocumentary; set => idDocumentary = value; }
        public string Title { get => title; set => title = value; }
        public string InvolvedUser { get => involvedUser; set => involvedUser = value; }

        public ExecutoryDocument() { }
    }
}
