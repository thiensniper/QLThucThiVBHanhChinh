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
        private User user;
        private bool logedOn;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(User user, bool logedOn): this()
        {
            this.user = user;
            this.logedOn = logedOn;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (user != null && logedOn)
                lblWelcome.Text = "Xin chào " + user.Fullname + "!";
            else
                Application.Exit();
        }

        private void picPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal Personal = new frmPersonal();
            this.Hide();
            Personal.ShowDialog();
            this.Show();
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
            this.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmPersonal Personal = new frmPersonal();
            this.Hide();
            Personal.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pic_Document_Click(object sender, EventArgs e)
        {
            frmDocumentary Document = new frmDocumentary();
            this.Hide();
            Document.ShowDialog();
            this.Show();
        }
    }
}
