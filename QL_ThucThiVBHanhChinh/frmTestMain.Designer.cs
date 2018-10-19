namespace QL_ThucThiVBHanhChinh
{
    partial class frmTestMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picPersonal = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QL_ThucThiVBHanhChinh.Properties.Resources.trang1;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.picPersonal);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pic_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 46);
            this.panel1.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(33, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(98, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin Chào ....";
            // 
            // picPersonal
            // 
            this.picPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPersonal.Image = global::QL_ThucThiVBHanhChinh.Properties.Resources.icons8_customer_1000;
            this.picPersonal.Location = new System.Drawing.Point(357, 8);
            this.picPersonal.Name = "picPersonal";
            this.picPersonal.Size = new System.Drawing.Size(35, 35);
            this.picPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonal.TabIndex = 0;
            this.picPersonal.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::QL_ThucThiVBHanhChinh.Properties.Resources.icons8_settings_1000;
            this.pictureBox2.Location = new System.Drawing.Point(398, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pic_Exit
            // 
            this.pic_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Exit.Image = global::QL_ThucThiVBHanhChinh.Properties.Resources.icons8_multiply_1000;
            this.pic_Exit.Location = new System.Drawing.Point(909, 8);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(35, 35);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Exit.TabIndex = 0;
            this.pic_Exit.TabStop = false;
            // 
            // frmTestMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2016 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmTestMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTestMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picPersonal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pic_Exit;
    }
}