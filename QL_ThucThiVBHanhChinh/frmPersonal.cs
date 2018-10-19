using QL_ThucThiVBHanhChinh.DAO;
using QL_ThucThiVBHanhChinh.DTO;
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
    public partial class frmPersonal : Form
    {
        #region Interface
        private bool visibleButtonSave_Cancel
        {
            get
            {
                return btnSave.Visible;
            }
            set
            {
                btnSave.Visible = value;
                btnCancel.Visible = value;
            }
        }
        private bool enableUserInfo
        {
            get
            {
                return txtFullname.Enabled;
            }
            set
            {
                btnChangeInfo.Enabled = !value;
                txtFullname.Enabled = value;
                txtEmail.Enabled = value;
                txtPhone.Enabled = value;
            }
        }
        private bool enableChangePassword
        {
            get
            {
                return txtOldPassword.Enabled;
            }
            set
            {
                txtOldPassword.Enabled = value;
                txtNewPassword.Enabled = value;
                txtConfirmPassword.Enabled = value;
                btnChangePassword.Enabled = !value;
            }
        }
        private void setTextBoxInfoUser(User data)
        {
            // Xóa textbox change password
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            // Truyền data
            lblUsername.Text = "Username: " + data.Username;
            txtId.Text = data.Id;
            txtFullname.Text = data.Fullname;
            txtEmail.Text = data.Email;
            txtPhone.Text = data.Phone;
            txtPosition.Text = data.Position;
        }
        #endregion

        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            if (SessionInfo.user == null) // Kiểm tra xem có user truyền vào không
                Application.Exit();

            // Xử lý giao diện
            visibleButtonSave_Cancel = false;
            enableUserInfo = false;
            enableChangePassword = false;

            // Truyền data
            setTextBoxInfoUser(SessionInfo.user);
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi phần hồ sơ cá nhân hay không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            // Xử lý giao diện
            visibleButtonSave_Cancel = true;
            enableUserInfo = true;

            // Xử lý tác vụ
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Xử lý giao diện
            enableChangePassword = true;
            visibleButtonSave_Cancel = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xử lý giao diện
            enableChangePassword = false;
            visibleButtonSave_Cancel = false;
            enableUserInfo = false;

            // Hủy việc sửa đổi thông tin user
            setTextBoxInfoUser(SessionInfo.user);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            User updateUser = new User(SessionInfo.user);
            if (enableUserInfo == true)
            {
                // Xử lý tác vụ cập nhật thông tin user
                updateUser.Fullname = txtFullname.Text;
                updateUser.Email = txtEmail.Text;
                updateUser.Phone = txtPhone.Text;
            }
            if (enableChangePassword == true)
            {
                // Xử lý tác vụ cập nhật password
                if (txtOldPassword.Text == SessionInfo.user.Password)
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        updateUser.Password = txtNewPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo!");
                }

            }
            // Xử lý cập nhật dữ liệu
            bool updated = false;
            if (!updateUser.equal(SessionInfo.user)) // Kiểm tra thông tin mới có giống thông tin cũ hay ko
            {
                updated = await UserDAO.Instance.updateUser(updateUser);
            }
            if (updated == true)
            {
                MessageBox.Show("Đã cập nhật thông tin thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SessionInfo.user = updateUser;
                setTextBoxInfoUser(SessionInfo.user);
            }
            else
            {
                MessageBox.Show("Không cập nhật được thông tin người dùng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setTextBoxInfoUser(SessionInfo.user);
            }

            // Xử lý giao diện
            //setTextBoxInfoUser(user);
            enableUserInfo = false;
            enableChangePassword = false;
            visibleButtonSave_Cancel = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }
    }
}
