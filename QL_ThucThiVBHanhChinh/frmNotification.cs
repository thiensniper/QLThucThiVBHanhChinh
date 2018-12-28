using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QL_ThucThiVBHanhChinh
{
    public partial class frmNotification : DevExpress.XtraEditors.XtraForm
    {
        int flag = 0;
        public frmNotification()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void eployeesTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int row = LIB.SelectedIndex;
            //if (row != -1) LIB.Items.RemoveAt(row);
            //TB.Focus();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //LIB.Items.Add(TB.Text);
            //TB.Clear();
            //TB.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    LIB.Items.Clear();
        //    TB.Focus();
        }

        private void tileBarItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            grTao.Visible = true;
            grXem.Visible = false;
        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            grTao.Visible = false;
            grXem.Visible = true;
        }

        private void employeesLabelControl_Click(object sender, EventArgs e)
        {

        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            grTao.Visible = true;
            grXem.Visible = false;
            grChon2.Visible = false;
            btnChon2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grChon2.Visible = true;
            btnChon1.Hide();
            btnChon2.Show();
        }

        private void btnChon2_Click(object sender, EventArgs e)
        {
            grChon2.Visible = false;
            btnChon1.Show();
            btnChon2.Hide();
        }
    }
}