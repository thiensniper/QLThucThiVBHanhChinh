namespace QL_ThucThiVBHanhChinh
{
    partial class frmLostPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pic_open = new System.Windows.Forms.PictureBox();
            this.Id_tool = new System.Windows.Forms.ToolTip(this.components);
            this.Email_tool = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(329, 40);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 37);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Id_tool.SetToolTip(this.txtUsername, "Vui lòng nhập vào tài khoản của bạn đã đăng kí trên hệ thống dữ liệu");
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(329, 87);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 37);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email_tool.SetToolTip(this.txtPassword, "Vui lòng nhập vào Email của bạn đã đăng kí trên hệ thống dữ liệu để nhận một mật " +
        "khẩu mới");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(177, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(178, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "EMAIL ĐĂNG KÝ";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(276, 144);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 39);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "GỬI MẬT KHẨU";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(446, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pic_open
            // 
            this.pic_open.Image = global::QL_ThucThiVBHanhChinh.Properties.Resources.khoa12;
            this.pic_open.Location = new System.Drawing.Point(37, 97);
            this.pic_open.Name = "pic_open";
            this.pic_open.Size = new System.Drawing.Size(93, 88);
            this.pic_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_open.TabIndex = 9;
            this.pic_open.TabStop = false;
            // 
            // Id_tool
            // 
            this.Id_tool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Id_tool.ToolTipTitle = "Tài Khoản";
            // 
            // Email_tool
            // 
            this.Email_tool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.Email_tool.ToolTipTitle = "Email";
            // 
            // frmLostPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_ThucThiVBHanhChinh.Properties.Resources.Untitled_231;
            this.ClientSize = new System.Drawing.Size(595, 246);
            this.Controls.Add(this.pic_open);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLostPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLostPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pic_open;
        private System.Windows.Forms.ToolTip Id_tool;
        private System.Windows.Forms.ToolTip Email_tool;
    }
}