﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_ThucThiVBHanhChinh.DAO;
using QL_ThucThiVBHanhChinh.DTO;


namespace QL_ThucThiVBHanhChinh
{
    public partial class frmLogin : Form
    {
        #region Methods
        public frmLogin()
        {
            InitializeComponent();
            
        }
        int dem = 0;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            SessionInfo.logedOn = false;
            pic_open.Hide();
            timerLogin.Enabled = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            List<User> listUser;
            try
            {
                listUser = await UserDAO.Instance.GetAllUsers();
            }
            catch(Exception ex)
            {
                listUser = null;
                Console.WriteLine(ex.Message);
            }
            if(listUser != null)
            {
                foreach(User data in listUser)
                {
                    Console.WriteLine(data.ToString());
                    if(txtUsername.Text == data.Username && txtPassword.Text == data.Password && data.Status == "true")
                    {
                        SessionInfo.logedOn = true;
                        SessionInfo.user = data;
                        break;
                    }
                }
            }


            // Xử lý đăng nhập thành công hay không thành công
            if (SessionInfo.logedOn == true && SessionInfo.user.Status == "true") // Thành công
            {
                // Làm màu :))
                pic_open.Show();
                pic_clock.Hide();

                // Xử lý đăng nhập
                timerLogin.Enabled = true;
            }
            else // Không thành công
            {
                btnLogin.Enabled = true;
                dem=dem+1;
                if (dem == 4) { MessageBox.Show("Bạn đã nhập sai quá nhiều lần, vui lòng đăng nhập lại sau", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning); Application.Exit(); }
                MessageBox.Show("Tài khoản hoặc mật khẩu bạn vừa nhập không đúng, vui lòng kiểm tra và thử lại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            //List<string> mail = new List<string>();
            //mail.Add("nguyenminhthiensmart@gmail.com");
            //EmailController.MailInstance.SendEmail("thienthanthanh.tn@gmail.com", "16031997", mail, new Email.TemplateEmail("Test QL Thuc thi VBHC", "Đây là Email Test"));
            timerLogin.Enabled = false;
            frmMain main = new frmMain();
            this.Hide();
            if (Application.OpenForms.Count >= 2) Application.OpenForms[1].Close();
            main.Show();
        }

        private void pic_open_Click(object sender, EventArgs e)
        {

        }

       

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void link_LostPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLostPassword LostPass = new frmLostPassword();
            this.Hide();
            LostPass.ShowDialog();
        }

        private void link_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister Register = new frmRegister();
            this.Hide();
            Register.ShowDialog();
        }
    }
}
