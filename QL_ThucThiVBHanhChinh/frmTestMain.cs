﻿using System;
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
    public partial class frmTestMain : DevExpress.XtraEditors.XtraForm
    {
        public frmTestMain()
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
    }
}