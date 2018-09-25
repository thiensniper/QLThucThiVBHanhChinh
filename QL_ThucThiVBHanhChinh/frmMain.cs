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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmPersonal Personal = new frmPersonal();
            this.Hide();
            Personal.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            this.Hide();
            setting.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmPersonal Personal = new frmPersonal();
            this.Hide();
            Personal.ShowDialog();
        }
    }
}
