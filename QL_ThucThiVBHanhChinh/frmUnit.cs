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
    public partial class frmUnit : Form
    {
        public frmUnit()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            
            pn2.Show();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
           
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pn2.Hide();

        }

        private void btnGuiVB_Click(object sender, EventArgs e)
        {
          
            pn2.Show();
        }
    }
}
