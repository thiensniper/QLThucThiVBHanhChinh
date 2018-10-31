using FireSharp.Response;
using QL_ThucThiVBHanhChinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThucThiVBHanhChinh.DAO
{
    class SettingDAO
    {
        private string urlSetting = "/setting";
        private static SettingDAO instance;

        internal static SettingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SettingDAO();
                return instance;
            }
            private set => instance = value;
        }

        private SettingDAO() { }

        public async Task<Setting> getSetting()
        {
            if (SessionInfo.user != null)
            {
                //FirebaseResponse response = await DataProvider.Instance.Get(urlSettingEmail + "/" + SessionInfo.user.Username + "/SettingEmail");
                //return response.ResultAs<string>();
                FirebaseResponse response = await FirebaseConnection.Instance.Get(urlSetting + "/" + SessionInfo.user.Username);
                dynamic obj = response.ResultAs<Setting>();

                return obj;
            }
            else
                throw new System.ArgumentException("User is null!", "original");
        }

        public async Task<bool> updateSetting(Setting setting)
        {
            SetResponse response = await FirebaseConnection.Instance.SetObject<Setting>(urlSetting + "/" + setting.Username, setting);
            if (response == null) return false;
            else return true;
        }
    }
}
