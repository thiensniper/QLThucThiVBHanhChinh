using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.Email
{
    class TemplateEmail
    {
        public string subject;
        public string body;

        public TemplateEmail() { }

        public TemplateEmail(string subject, string body)
        {
            this.subject = subject;
            this.body = body;
        }
    }
}
