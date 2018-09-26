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

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi phần cài đặt chương trình hay không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
