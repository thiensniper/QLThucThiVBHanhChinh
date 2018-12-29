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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //public static bool logedOn;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //if (Application.OpenForms[0].Text == "Đăng nhập") Application.OpenForms[0].Close();
            if (SessionInfo.user != null && SessionInfo.logedOn)
            {
                btnInfor.Visible = false;
                lblWelcome.Text = "Xin chào " + SessionInfo.user.Fullname + " !";
                //kiem tra quyen cua nguoi dang nhap ==> quyet dinh quyen dung chuc nang cua form quan ly
                if (SessionInfo.user.Role == "user")
                {
                    btnInfor.Visible = true;
                    pic_Statistical.Enabled = false;
                    label4.Enabled = false;
                    pictureBox11.Enabled = false;
                }
                else
                {
                    btnInfor.Visible = false;
                    pic_Statistical.Enabled = true;
                    label4.Enabled = true;
                    pictureBox11.Enabled = true;
                }
            }
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


        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pic_demo1_Click(object sender, EventArgs e)
        {
            frmTest1 frmUser1 = new frmTest1();
            this.Hide();
            frmUser1.ShowDialog();
            this.Show();
        }

        private void pic_demo2_Click(object sender, EventArgs e)
        {
            frmViewDocument frmUser2 = new frmViewDocument();
            this.Hide();
            frmUser2.ShowDialog();
            this.Show();
        }

        private void pic_demo3_Click(object sender, EventArgs e)
        {

        }




        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSetting setting = new frmSetting();
            this.Hide();
            setting.ShowDialog();
            this.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPersonal Personal = new frmPersonal();
            this.Hide();
            Personal.ShowDialog();
            this.Show();
            frmMain_Load(sender, e);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult ExitCT2 = new DialogResult();
            ExitCT2 = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN ĐĂNG XUẤT VÀ TRỞ VỀ MÀN HÌNH ĐĂNG NHẬP HAY KHÔNG?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (ExitCT2 == DialogResult.OK)
            {
                SessionInfo.logedOn = false;
                SessionInfo.user = null;
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
            if (ExitCT2 == DialogResult.Cancel) { }



        }
        private void pic_Remind_Click(object sender, EventArgs e)
        {
            frmNotification Notification = new frmNotification();
            this.Hide();
            Notification.ShowDialog();
            this.Show();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn hiện không có quyền truy cập chức năng này, vui lòng liên hệ với người quản lý để có mức truy cập cao hơn.!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult thoatct = new DialogResult();
            thoatct = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT CHƯƠNG TRÌNH NÀY HAY KHÔNG?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (thoatct == DialogResult.OK) { Application.Exit(); }
            if (thoatct == DialogResult.Cancel) { }

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1) Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNotification Notification = new frmNotification();
            this.Hide();
            Notification.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNotification Notification = new frmNotification();
            this.Hide();
            Notification.ShowDialog();
            this.Show();
        }
    }
}
