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
    public partial class frmLostPassword : Form
    {
        public frmLostPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            frmLogin Login = new frmLogin();
            this.Close();
            Login.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu bạn nhập đúng tài khoản và Email mà bạn đã đăng kí trên hệ thống, chúng tôi đã gửi một mật khẩu mới đến email của bạn, vui lòng kiểm tra Email để kích hoạt mật khâu mới của bạn ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            frmLogin Login = new frmLogin();
            this.Close();
            Login.ShowDialog();
        }

        private void pic_open_Click(object sender, EventArgs e)
        {

        }
    }
}
