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
using QL_ThucThiVBHanhChinh.DAO;
using QL_ThucThiVBHanhChinh.DTO;

namespace QL_ThucThiVBHanhChinh
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        #region Interface Properties
        /*=================================================*/
        private bool modeNormal // Thiết lập giao diện mặc định khi load form
        {
            get
            {
                if (btnAdd.Enabled == true && btnSave.Enabled == false)
                    return true;
                else return false;
            }
            set
            {
                ClearTextbox();
                btnAdd.Enabled = value;
                btnDelete.Enabled = value;
                btnEdit.Enabled = value;
                btnSave.Enabled = !value;
                btnCancel.Enabled = !value;
                txtUsername.ReadOnly = value;
                txtEmail.Enabled = !value;
                txtFullname.Enabled = !value;
                txtId.Enabled = !value;
                cbbFaculty.Enabled = !value;
                txtPosition.Enabled = !value;
                txtPassword.Enabled = !value;
                cbbRole.Enabled = !value;
                cbbStatus.Enabled = !value;
                txtPhone.Enabled = !value;
            }
        }

        private bool modeAdd //Thiết lập giao diện thao tác thêm user
        {
            get
            {
                if (btnAdd.Enabled == false && btnDelete.Enabled == false
                    && btnEdit.Enabled == false && btnSave.Enabled == true)
                    return true;
                else return false;
            }
            set
            {
                ClearTextbox();
                btnAdd.Enabled = !value;
                btnDelete.Enabled = !value;
                btnEdit.Enabled = !value;
                btnSave.Enabled = value;
                btnCancel.Enabled = value;
                txtUsername.ReadOnly = !value;
                txtEmail.Enabled = value;
                txtFullname.Enabled = value;
                txtId.Enabled = value;
                cbbFaculty.Enabled = value;
                txtPosition.Enabled = value;
                txtPassword.Enabled = value;
                cbbRole.Enabled = value;
                cbbStatus.Enabled = value;
                txtPhone.Enabled = value;
            }
        }
        private bool modeEdit // Thiết lập giao diện thao tác chỉnh sửa user
        {
            get
            {
                if (btnAdd.Enabled == false && btnDelete.Enabled == false
                    && btnEdit.Enabled == false && btnSave.Enabled == true)
                    return true;
                else return false;
            }
            set
            {
                LoadDataTextboxFromDgv();
                btnAdd.Enabled = !value;
                btnDelete.Enabled = !value;
                btnEdit.Enabled = !value;
                btnSave.Enabled = value;
                btnCancel.Enabled = value;
                txtUsername.ReadOnly = value;
                txtEmail.Enabled = value;
                txtFullname.Enabled = value;
                txtId.Enabled = value;
                cbbFaculty.Enabled = value;
                txtPosition.Enabled = value;
                txtPassword.Enabled = value;
                cbbRole.Enabled = value;
                cbbStatus.Enabled = value;
                txtPhone.Enabled = value;
            }
        }
        #endregion
        #region Interface Methods
        private void ClearTextbox()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtFullname.Clear();
            txtId.Clear();
            cbbFaculty.SelectedValue = "";
            txtPassword.Clear();
            txtPosition.Clear();
            cbbRole.Text = "";
            cbbRole.SelectedValue = null;
            cbbStatus.Text = "";
            cbbStatus.SelectedValue = null;
            txtPhone.Clear();
        }

        private void LoadDataTextboxFromDgv()
        {
            cbbStatus.Text = "";
            cbbRole.Text = "";
            txtUsername.Text = dgvUser.SelectedRows[0].Cells["Username"].Value.ToString();
            txtEmail.Text = dgvUser.SelectedRows[0].Cells["Email"].Value.ToString();
            txtFullname.Text = dgvUser.SelectedRows[0].Cells["Fullname"].Value.ToString();
            txtId.Text = dgvUser.SelectedRows[0].Cells["Id"].Value.ToString();
            cbbFaculty.SelectedValue = dgvUser.SelectedRows[0].Cells["IdFaculty"].Value.ToString();
            txtPassword.Text = dgvUser.SelectedRows[0].Cells["Password"].Value.ToString();
            txtPosition.Text = dgvUser.SelectedRows[0].Cells["Position"].Value.ToString();
            cbbRole.SelectedText = dgvUser.SelectedRows[0].Cells["Role"].Value.ToString();
            cbbStatus.SelectedText = dgvUser.SelectedRows[0].Cells["Status"].Value.ToString();
            txtPhone.Text = dgvUser.SelectedRows[0].Cells["Phone"].Value.ToString();
        }

        public bool checkEmptyField()
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtFullname.Text == "") return false;
            if (txtId.Text == "" || txtPassword.Text == "" || cbbFaculty.SelectedIndex == -1) return false;
            if (txtPosition.Text == "" || cbbRole.SelectedIndex == -1 || cbbStatus.SelectedIndex == -1 || txtPhone.Text == "") return false;
            return true;
        }
        
        public bool checkValidPassword()
        {
            if (txtPassword.Text.Length < 5) return false;
            return true;
        }
        #endregion
        /*=================================================*/
        public frmUser()
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

        private void btnQuayVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void navBarControl_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("test thanh cong","thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information)
        }

        private void btnDSNS_Click_1(object sender, EventArgs e)
        {
            frmUser2 frmUser2 = new frmUser2();
            this.Hide();
            frmUser2.ShowDialog();
            this.Show();
        }

        private void employeesLabelControl_Click(object sender, EventArgs e)
        {

        }

        private async void frmUser_Load(object sender, EventArgs e)
        {
            // Xử lý giao diện
            modeNormal = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            // Load dữ liệu lên form
            dgvUser.DataSource = await UserDAO.Instance.getUsers();
            cbbFaculty.DataSource = await FacultyDAO.Instance.getAllFaculty();
            cbbFaculty.DisplayMember = "Name";
            cbbFaculty.ValueMember = "Id";

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonNavigation_ItemClick(sender,e);
        }


        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modeNormal = true;
            // Load dữ liệu lên text box
            LoadDataTextboxFromDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            modeAdd = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            modeNormal = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (modeAdd == true)
            {
                if (checkEmptyField())
                {
                    if (checkValidPassword())
                    {
                        User newUser = new User(txtId.Text, txtUsername.Text, txtFullname.Text, txtEmail.Text,
                            txtPhone.Text, txtPosition.Text, cbbFaculty.SelectedValue.ToString(), cbbRole.SelectedText,
                            txtPassword.Text, cbbStatus.SelectedText);
                        bool isCompleted = await UserDAO.Instance.updateUser(newUser);
                        if (isCompleted) MessageBox.Show("Thêm mới thành công!", "Thông báo");
                        else MessageBox.Show("Thêm mới thất bại!", "Thông báo");
                        // Load lại datagridview
                        dgvUser.DataSource = await UserDAO.Instance.getUsers();
                        modeNormal = true;
                    }
                    else MessageBox.Show("Mật khẩu phải từ 6 kí tự trở lên!", "Thông báo");
                }
                else MessageBox.Show("Thông tin người dùng không được để trống!", "Thông báo");
            }
        }
    }
}