﻿using System;
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
    public partial class frmDocumentary : Form
    {
        public frmDocumentary()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void frmDocumentary_Load(object sender, EventArgs e)
        {

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
