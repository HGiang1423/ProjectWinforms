namespace GUII
{
    partial class CustomerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGUI));
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.tbmalop = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngNhàTrườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngNghệThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mạngMáyTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngNghệThôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaCơKhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaQuảnTrịKinhDoanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaDệtMayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaĐiệnĐiệnTửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaNgoạiNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.malop});
            this.dgvCustomer.Location = new System.Drawing.Point(0, 369);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(954, 275);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_gender";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 135;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 135;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExit.Location = new System.Drawing.Point(826, 292);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(89, 63);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên: ";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbId.Location = new System.Drawing.Point(124, 53);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(205, 27);
            this.tbId.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbName.Location = new System.Drawing.Point(124, 108);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(265, 27);
            this.tbName.TabIndex = 12;
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(124, 157);
            this.cbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(115, 27);
            this.cbArea.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(287, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "HỆ THỐNG SINH VIÊN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(17, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(17, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã lớp: ";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(708, 292);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(89, 63);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Xóa";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(826, 225);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(89, 63);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Sửa";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btNew.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNew.Image = ((System.Drawing.Image)(resources.GetObject("btNew.Image")));
            this.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNew.Location = new System.Drawing.Point(708, 225);
            this.btNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(89, 63);
            this.btNew.TabIndex = 1;
            this.btNew.Text = "Thêm";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // tbmalop
            // 
            this.tbmalop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbmalop.Location = new System.Drawing.Point(124, 215);
            this.tbmalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmalop.Name = "tbmalop";
            this.tbmalop.Size = new System.Drawing.Size(205, 27);
            this.tbmalop.TabIndex = 12;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTK.Location = new System.Drawing.Point(736, 153);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(129, 51);
            this.btnTK.TabIndex = 22;
            this.btnTK.Text = "THỐNG KÊ";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.hệThốngNhàTrườngToolStripMenuItem,
            this.khoaToolStripMenuItem,
            this.thôngBáoToolStripMenuItem,
            this.liênHệToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 30);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // hệThốngNhàTrườngToolStripMenuItem
            // 
            this.hệThốngNhàTrườngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinGiảngViênToolStripMenuItem,
            this.thôngTinSinhViênToolStripMenuItem});
            this.hệThốngNhàTrườngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hệThốngNhàTrườngToolStripMenuItem.Name = "hệThốngNhàTrườngToolStripMenuItem";
            this.hệThốngNhàTrườngToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.hệThốngNhàTrườngToolStripMenuItem.Text = "Hệ thống nhà trường";
            // 
            // thôngTinGiảngViênToolStripMenuItem
            // 
            this.thôngTinGiảngViênToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinGiảngViênToolStripMenuItem.Name = "thôngTinGiảngViênToolStripMenuItem";
            this.thôngTinGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.thôngTinGiảngViênToolStripMenuItem.Text = "Thông tin giảng viên";
            this.thôngTinGiảngViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinGiảngViênToolStripMenuItem_Click);
            // 
            // thôngTinSinhViênToolStripMenuItem
            // 
            this.thôngTinSinhViênToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinSinhViênToolStripMenuItem.Name = "thôngTinSinhViênToolStripMenuItem";
            this.thôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.thôngTinSinhViênToolStripMenuItem.Text = "Thông tin sinh viên";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngNghệThôngTinToolStripMenuItem,
            this.khoaCơKhíToolStripMenuItem,
            this.khoaQuảnTrịKinhDoanhToolStripMenuItem,
            this.khoaDệtMayToolStripMenuItem,
            this.khoaĐiệnĐiệnTửToolStripMenuItem,
            this.khoaNgoạiNgữToolStripMenuItem});
            this.khoaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.khoaToolStripMenuItem.Text = "Các ngành đào tạo";
            // 
            // côngNghệThôngTinToolStripMenuItem
            // 
            this.côngNghệThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mạngMáyTínhToolStripMenuItem,
            this.côngNghệThôngTinToolStripMenuItem1});
            this.côngNghệThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.côngNghệThôngTinToolStripMenuItem.Name = "côngNghệThôngTinToolStripMenuItem";
            this.côngNghệThôngTinToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.côngNghệThôngTinToolStripMenuItem.Text = "Khoa Công nghệ thông tin";
            // 
            // mạngMáyTínhToolStripMenuItem
            // 
            this.mạngMáyTínhToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mạngMáyTínhToolStripMenuItem.Name = "mạngMáyTínhToolStripMenuItem";
            this.mạngMáyTínhToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.mạngMáyTínhToolStripMenuItem.Text = "Mạng máy tính";
            // 
            // côngNghệThôngTinToolStripMenuItem1
            // 
            this.côngNghệThôngTinToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.côngNghệThôngTinToolStripMenuItem1.Name = "côngNghệThôngTinToolStripMenuItem1";
            this.côngNghệThôngTinToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.côngNghệThôngTinToolStripMenuItem1.Text = "Công nghệ thông tin";
            // 
            // khoaCơKhíToolStripMenuItem
            // 
            this.khoaCơKhíToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khoaCơKhíToolStripMenuItem.Name = "khoaCơKhíToolStripMenuItem";
            this.khoaCơKhíToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.khoaCơKhíToolStripMenuItem.Text = "Khoa Cơ Khí";
            // 
            // khoaQuảnTrịKinhDoanhToolStripMenuItem
            // 
            this.khoaQuảnTrịKinhDoanhToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khoaQuảnTrịKinhDoanhToolStripMenuItem.Name = "khoaQuảnTrịKinhDoanhToolStripMenuItem";
            this.khoaQuảnTrịKinhDoanhToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.khoaQuảnTrịKinhDoanhToolStripMenuItem.Text = "Khoa Quản trị kinh doanh";
            // 
            // khoaDệtMayToolStripMenuItem
            // 
            this.khoaDệtMayToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khoaDệtMayToolStripMenuItem.Name = "khoaDệtMayToolStripMenuItem";
            this.khoaDệtMayToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.khoaDệtMayToolStripMenuItem.Text = "Khoa Dệt may";
            // 
            // khoaĐiệnĐiệnTửToolStripMenuItem
            // 
            this.khoaĐiệnĐiệnTửToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khoaĐiệnĐiệnTửToolStripMenuItem.Name = "khoaĐiệnĐiệnTửToolStripMenuItem";
            this.khoaĐiệnĐiệnTửToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.khoaĐiệnĐiệnTửToolStripMenuItem.Text = "Khoa Điện -  Điện tử";
            // 
            // khoaNgoạiNgữToolStripMenuItem
            // 
            this.khoaNgoạiNgữToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.khoaNgoạiNgữToolStripMenuItem.Name = "khoaNgoạiNgữToolStripMenuItem";
            this.khoaNgoạiNgữToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.khoaNgoạiNgữToolStripMenuItem.Text = "Khoa Ngoại ngữ";
            // 
            // thôngBáoToolStripMenuItem
            // 
            this.thôngBáoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngBáoToolStripMenuItem.Name = "thôngBáoToolStripMenuItem";
            this.thôngBáoToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.thôngBáoToolStripMenuItem.Text = "Thông báo";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.liênHệToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbmalop);
            this.groupBox2.Controls.Add(this.cbArea);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 262);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(528, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 41);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "  Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(674, 102);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(241, 27);
            this.tbSearch.TabIndex = 60;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(494, 153);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(156, 138);
            this.pbImage.TabIndex = 62;
            this.pbImage.TabStop = false;
            // 
            // btFile
            // 
            this.btFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFile.Location = new System.Drawing.Point(516, 304);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(116, 51);
            this.btFile.TabIndex = 63;
            this.btFile.Text = "Chọn ảnh...";
            this.btFile.UseVisualStyleBackColor = false;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(954, 644);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCustomer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerGUI";
            this.Load += new System.EventHandler(this.CustomerGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmalop;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngNhàTrườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngNghệThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mạngMáyTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngNghệThôngTinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem khoaCơKhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaQuảnTrịKinhDoanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaDệtMayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaĐiệnĐiệnTửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoaNgoạiNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile;
    }
}