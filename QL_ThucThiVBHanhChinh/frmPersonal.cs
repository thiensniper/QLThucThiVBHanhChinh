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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            btnSave.Hide();
            btnCancel.Hide();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi phần hồ sơ cá nhân hay không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            frmMain main = new frmMain();
            this.Close();
            main.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnSave.Show();
            btnCancel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
