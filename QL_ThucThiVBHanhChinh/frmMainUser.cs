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
    public partial class frmMainUser : DevExpress.XtraEditors.XtraForm
    {
        public frmMainUser()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
           // navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void frmTestMain_Load(object sender, EventArgs e)
        {
    
        }

        
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}