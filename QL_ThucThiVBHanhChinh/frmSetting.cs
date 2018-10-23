using QL_ThucThiVBHanhChinh.DAO;
using QL_ThucThiVBHanhChinh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThucThiVBHanhChinh
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private async void frmSetting_Load(object sender, EventArgs e)
        {
            Setting setting = await SettingDAO.Instance.getSetting();
            if (setting != null)
            {
                txtSendingEmail.Text = setting.SettingEmail;
                txtEmailPassword.Text = setting.EmailPassword;
            }
            else
            {
                txtSendingEmail.Text = SessionInfo.user.Email;
                MessageBox.Show("Bạn chưa có thông tin thiết đặt! Vui lòng thiết đặt và cập nhật thông tin!", "Thông báo");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi phần cài đặt chương trình hay không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private async void btn_UpdateEmail_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(SessionInfo.user.Username, txtSendingEmail.Text, txtEmailPassword.Text);
            bool updated = false;
            updated = await SettingDAO.Instance.updateSetting(setting);
            if (updated == true)
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            else
                MessageBox.Show("Chưa cập nhật được thông tin!", "Thông báo");
        }
    }
}
