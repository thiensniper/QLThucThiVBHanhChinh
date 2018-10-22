namespace QL_ThucThiVBHanhChinh
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_clock = new System.Windows.Forms.PictureBox();
            this.pic_open = new System.Windows.Forms.PictureBox();
            this.timerLogin = new System.Windows.Forms.Timer(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.link_LostPass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(310, 26);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(258, 37);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.Location = new System.Drawing.Point(430, 127);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(310, 73);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(258, 37);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(198, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "MẬT KHẨU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pic_clock
            // 
            this.pic_clock.Image = global::QL_ThucThiVBHanhChinh.Properties.Resources.khoa12;
            this.pic_clock.Location = new System.Drawing.Point(37, 97);
            this.pic_clock.Name = "pic_clock";
            this.pic_clock.Size = new System.Drawing.Size(93, 88);
            this.pic_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_clock.TabIndex = 3;
            this.pic_clock.TabStop = false;
            // 
            // pic_open
            // 
            this.pic_open.Image = global::QL_ThucThiVBHanhChinh.Properties.Resources.khoa3;
            this.pic_open.Location = new System.Drawing.Point(37, 97);
            this.pic_open.Name = "pic_open";
            this.pic_open.Size = new System.Drawing.Size(93, 88);
            this.pic_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_open.TabIndex = 4;
            this.pic_open.TabStop = false;
            this.pic_open.Click += new System.EventHandler(this.pic_open_Click);
            // 
            // timerLogin
            // 
            this.timerLogin.Interval = 500;
            this.timerLogin.Tick += new System.EventHandler(this.timerLogin_Tick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(270, 127);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 39);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // link_LostPass
            // 
            this.link_LostPass.AutoSize = true;
            this.link_LostPass.BackColor = System.Drawing.Color.Transparent;
            this.link_LostPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_LostPass.Location = new System.Drawing.Point(442, 176);
            this.link_LostPass.Name = "link_LostPass";
            this.link_LostPass.Size = new System.Drawing.Size(126, 20);
            this.link_LostPass.TabIndex = 6;
            this.link_LostPass.TabStop = true;
            this.link_LostPass.Text = "Quên mật khẩu !";
            this.link_LostPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LostPass_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_ThucThiVBHanhChinh.Properties.Resources.Untitled_23;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(595, 246);
            this.Controls.Add(this.link_LostPass);
            this.Controls.Add(this.pic_open);
            this.Controls.Add(this.pic_clock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_clock;
        private System.Windows.Forms.PictureBox pic_open;
        private System.Windows.Forms.Timer timerLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel link_LostPass;
    }
}

