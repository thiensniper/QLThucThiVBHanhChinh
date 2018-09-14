using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using QL_ThucThiVBHanhChinh.DAO;
using QL_ThucThiVBHanhChinh.DTO;


namespace QL_ThucThiVBHanhChinh
{
    public partial class frmLogin : Form
    {
        #region Properties
        string loginURL = @"https://qlvbhc-90731.firebaseio.com/user.json";
        HttpRequest httpClient;
        #endregion

        #region Methods
        public frmLogin()
        {
            InitializeComponent();

            httpClient = new HttpRequest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pic_open.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            MessageBox.Show(DataProvider.Instance.getObjects(loginURL).ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                pic_open.Show();
                pic_clock.Hide();
                //this.Close();
                
            }
        }
        
        #endregion
    }
}
