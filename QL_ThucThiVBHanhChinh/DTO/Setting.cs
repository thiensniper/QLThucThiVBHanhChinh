using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DTO
{
    class Setting
    {
        private string username;
        private string settingEmail;
        private string emailPassword;

        public string Username { get => username; set => username = value; }
        public string SettingEmail { get => settingEmail; set => settingEmail = value; }
        public string EmailPassword { get => emailPassword; set => emailPassword = value; }

        public Setting() { }

        public Setting(string username, string settingEmail, string emailPassword)
        {
            this.username = username;
            this.settingEmail = settingEmail;
            this.emailPassword = emailPassword;
        }
    }
}
