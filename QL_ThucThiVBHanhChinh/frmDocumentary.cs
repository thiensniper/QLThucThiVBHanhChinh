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
using QL_ThucThiVBHanhChinh.DTO;

namespace QL_ThucThiVBHanhChinh
{
    public partial class frmDocumentary : DevExpress.XtraEditors.XtraForm
    {
        public frmDocumentary()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void navBarItem_TimVanBan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            grbTimKiem.Show();
            grbHienThi.Show();
            tbTimKiem.Focus();
        }

        private void navBarItem_GuiVanBan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            grbTimKiem.Hide();
            grbHienThi.Hide();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonNavigation_ItemClick(sender,e);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn hủy việc tạo thực thi hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private async void frmDocumentary_Load(object sender, EventArgs e)
        {
            if (await DAO.ExecutoryDocumentDAO.Instance.getListExecutory() != null)
                dgvExecutory.DataSource = await DAO.ExecutoryDocumentDAO.Instance.getListExecutory();
        }
    }
}