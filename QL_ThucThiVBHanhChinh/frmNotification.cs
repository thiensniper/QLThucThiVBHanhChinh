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
    }
}