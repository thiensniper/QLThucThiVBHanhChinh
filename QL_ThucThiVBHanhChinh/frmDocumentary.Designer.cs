namespace QL_ThucThiVBHanhChinh
{
    partial class frmDocumentary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentary));
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.customersNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_TaoThucThi = new DevExpress.XtraNavBar.NavBarItem();
            this.employeesNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem_TimVanBan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem_GuiVanBan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grbHienThi = new System.Windows.Forms.GroupBox();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grbTaoThucThi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuayVe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.customersNavigationPage.SuspendLayout();
            this.grbTaoThucThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.customersNavBarGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.employeesNavBarGroup,
            this.customersNavBarGroup,
            this.navBarGroup1});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem_TimVanBan,
            this.navBarItem_GuiVanBan,
            this.navBarItem_TaoThucThi});
            this.navBarControl.Location = new System.Drawing.Point(0, 52);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 165;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.Size = new System.Drawing.Size(165, 543);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl";
            this.navBarControl.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // customersNavBarGroup
            // 
            this.customersNavBarGroup.Caption = "Thực Thi";
            this.customersNavBarGroup.Expanded = true;
            this.customersNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_TaoThucThi)});
            this.customersNavBarGroup.Name = "customersNavBarGroup";
            // 
            // navBarItem_TaoThucThi
            // 
            this.navBarItem_TaoThucThi.Caption = "Tạo Mục Thực Thi";
            this.navBarItem_TaoThucThi.Name = "navBarItem_TaoThucThi";
            this.navBarItem_TaoThucThi.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_TaoThucThi_LinkPressed);
            // 
            // employeesNavBarGroup
            // 
            this.employeesNavBarGroup.Caption = "Quản Lý Văn Bản";
            this.employeesNavBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_TimVanBan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem_GuiVanBan)});
            this.employeesNavBarGroup.Name = "employeesNavBarGroup";
            // 
            // navBarItem_TimVanBan
            // 
            this.navBarItem_TimVanBan.Caption = "Tìm Kiếm Văn Bản";
            this.navBarItem_TimVanBan.Name = "navBarItem_TimVanBan";
            this.navBarItem_TimVanBan.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_TimVanBan_LinkPressed);
            this.navBarItem_TimVanBan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_TimVanBan_LinkClicked);
            // 
            // navBarItem_GuiVanBan
            // 
            this.navBarItem_GuiVanBan.Caption = "Gửi Văn Bản";
            this.navBarItem_GuiVanBan.Name = "navBarItem_GuiVanBan";
            this.navBarItem_GuiVanBan.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_GuiVanBan_LinkPressed);
            this.navBarItem_GuiVanBan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_GuiVanBan_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Thống Kê";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(165, 52);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage,
            this.navigationPage1});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(625, 543);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Controls.Add(this.grbHienThi);
            this.employeesNavigationPage.Controls.Add(this.grbTimKiem);
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(625, 543);
            // 
            // grbHienThi
            // 
            this.grbHienThi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grbHienThi.Location = new System.Drawing.Point(6, 85);
            this.grbHienThi.Name = "grbHienThi";
            this.grbHienThi.Size = new System.Drawing.Size(616, 428);
            this.grbHienThi.TabIndex = 2;
            this.grbHienThi.TabStop = false;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.tbTimKiem);
            this.grbTimKiem.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grbTimKiem.Location = new System.Drawing.Point(6, 6);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(616, 73);
            this.grbTimKiem.TabIndex = 2;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Nhập Vào Văn Bản Cần Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(505, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 36);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tbTimKiem.Location = new System.Drawing.Point(8, 24);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(493, 36);
            this.tbTimKiem.TabIndex = 1;
            this.tbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(625, 543);
            this.employeesLabelControl.TabIndex = 0;
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Controls.Add(this.grbTaoThucThi);
            this.customersNavigationPage.Controls.Add(this.label1);
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(625, 543);
            // 
            // grbTaoThucThi
            // 
            this.grbTaoThucThi.Controls.Add(this.dataGridView1);
            this.grbTaoThucThi.Controls.Add(this.comboBox1);
            this.grbTaoThucThi.Controls.Add(this.radioButton2);
            this.grbTaoThucThi.Controls.Add(this.radioButton1);
            this.grbTaoThucThi.Controls.Add(this.textBox2);
            this.grbTaoThucThi.Controls.Add(this.textBox1);
            this.grbTaoThucThi.Controls.Add(this.label2);
            this.grbTaoThucThi.Controls.Add(this.label4);
            this.grbTaoThucThi.Controls.Add(this.label3);
            this.grbTaoThucThi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grbTaoThucThi.Location = new System.Drawing.Point(6, 6);
            this.grbTaoThucThi.Name = "grbTaoThucThi";
            this.grbTaoThucThi.Size = new System.Drawing.Size(607, 534);
            this.grbTaoThucThi.TabIndex = 4;
            this.grbTaoThucThi.TabStop = false;
            this.grbTaoThucThi.Text = "Tạo Thực Thi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 283);
            this.dataGridView1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.radioButton2.Location = new System.Drawing.Point(19, 154);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 28);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ngày Bắt Đầu";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.radioButton1.Location = new System.Drawing.Point(19, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(151, 28);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ngày Bắt Đầu";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 33);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 33);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiêu Đề Mục Thực Thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đối Tượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thêm Văn Bản Cần Thực Thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(625, 543);
            this.customersLabelControl.TabIndex = 1;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(625, 543);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.btnQuayVe});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 1;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 52);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            this.employeesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Customers";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            this.customersBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Caption = "Quay Về";
            this.btnQuayVe.Id = 46;
            this.btnQuayVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayVe.ImageOptions.Image")));
            this.btnQuayVe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuayVe.ImageOptions.LargeImage")));
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuayVe_Click);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNavigation});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Tác Vụ";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.btnQuayVe);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
            // 
            // frmDocumentary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.MaximizeBox = false;
            this.Name = "frmDocumentary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VĂN BẢN HÀNH CHÍNH";
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.customersNavigationPage.ResumeLayout(false);
            this.customersNavigationPage.PerformLayout();
            this.grbTaoThucThi.ResumeLayout(false);
            this.grbTaoThucThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup employeesNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup customersNavBarGroup;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_TimVanBan;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_GuiVanBan;
        private System.Windows.Forms.GroupBox grbHienThi;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private DevExpress.XtraBars.BarButtonItem btnQuayVe;
        private DevExpress.XtraNavBar.NavBarItem navBarItem_TaoThucThi;
        private System.Windows.Forms.GroupBox grbTaoThucThi;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}