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
    public partial class frmMain : Form
    {
        //public static bool logedOn;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (SessionInfo.user != null && SessionInfo.logedOn)
                lblWelcome.Text = "Xin chào " + SessionInfo.user.Fullname + "!";
            else
                this.Close();
        }


        private void picPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal Personal = new frmPersonal();
            this.Hide();
            Personal.ShowDialog();
            this.Show();
            frmMain_Load(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            DialogResult ExitCT = new DialogResult();
            ExitCT = MessageBox.Show("Bạn có chắc muốn đăng xuất và thoát khỏi chương trình hay không", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (ExitCT == DialogResult.OK) { Application.Exit(); }
            if (ExitCT == DialogResult.Cancel) { }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            this.Hide();
            setting.ShowDialog();
            this.Show();
        }

        //private void pictureBox7_Click(object sender, EventArgs e)
        //{
        //    frmPersonal Personal = new frmPersonal();
        //    this.Hide();
        //    Personal.ShowDialog();
        //}

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{
            
        //}

        private void pic_Document_Click(object sender, EventArgs e)
        {
            frmDocumentary Document = new frmDocumentary();
            this.Hide();
            Document.ShowDialog();
            this.Show();
        }

        private void pic_Unit_Click(object sender, EventArgs e)
        {
            frmUnit Unit = new frmUnit();
            this.Hide();
            Unit.ShowDialog();
            this.Show();
        }

        private void pic_Statistical_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            this.Hide();
            frmUser.ShowDialog();
            this.Show();
        }

        private void frm1_Click(object sender, EventArgs e)
        {
            frmDocumentary frmTest = new frmDocumentary();
            this.Hide();
            frmTest.ShowDialog();
            this.Show();
        }

        private void frm2_Click(object sender, EventArgs e)
        {
          
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pic_demo1_Click(object sender, EventArgs e)
        {
            frmUser1 frmUser1 = new frmUser1();
            this.Hide();
            frmUser1.ShowDialog();
            this.Show();
        }

        private void pic_demo2_Click(object sender, EventArgs e)
        {
            frmUser2 frmUser2 = new frmUser2();
            this.Hide();
            frmUser2.ShowDialog();
            this.Show();
        }

        private void pic_demo3_Click(object sender, EventArgs e)
        {
            frmMainUser frmMainUser = new frmMainUser();
            this.Hide();
            frmMainUser.ShowDialog();
            this.Show();
        }
    }
}
