using System;
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
        #region Properties
        private bool logOn;
        private User user;
        #endregion

        #region Methods
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            logOn = false;
            pic_open.Hide();
            timerLogin.Enabled = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> listUser;
            listUser = await UserDAO.Instance.getUsers();
            if(listUser != null)
            {
                foreach(User data in listUser)
                {
                    Console.WriteLine(data.ToString());
                    if(txtUsername.Text == data.Username && txtPassword.Text == data.Password)
                    {
                        logOn = true;
                        user = data;
                        break;
                    }
                }
            }


            
            if (logOn == true && user.Status == "true")
            {
                pic_open.Show();
                pic_clock.Hide();
                //this.Close();
                timerLogin.Enabled = true;
            }
            this.Hide();
        }

        #endregion

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            timerLogin.Enabled = !timerLogin.Enabled;
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void pic_open_Click(object sender, EventArgs e)
        {

        }
    }
}
