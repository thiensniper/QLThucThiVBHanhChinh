using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DTO
{
    class Faculty
    {
        private string id;
        private string name;
        private string presenterId;
        private string type;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PresenterId { get => presenterId; set => presenterId = value; }
        public string Type { get => type; set => type = value; }

        public Faculty()
        {
        }

        public Faculty(string id, string name, string presenterId, string type)
        {
            this.id = id;
            this.name = name;
            this.presenterId = presenterId;
            this.type = type;
        }
    }
}
