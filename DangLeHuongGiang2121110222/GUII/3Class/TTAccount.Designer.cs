namespace GUII._3Class
{
    partial class TTAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTAccount));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTTAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btExit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTAdmin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(466, 65);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(146, 27);
            this.tbSearch.TabIndex = 67;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(371, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 41);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "  Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTTAdmin
            // 
            this.dgvTTAdmin.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTTAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.mk});
            this.dgvTTAdmin.Location = new System.Drawing.Point(-1, 254);
            this.dgvTTAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTTAdmin.Name = "dgvTTAdmin";
            this.dgvTTAdmin.RowHeadersWidth = 51;
            this.dgvTTAdmin.RowTemplate.Height = 24;
            this.dgvTTAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTAdmin.Size = new System.Drawing.Size(679, 174);
            this.dgvTTAdmin.TabIndex = 66;
            this.dgvTTAdmin.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTAdmin_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
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
            this.Column2.Width = 125;
            // 
            // mk
            // 
            this.mk.DataPropertyName = "mk";
            this.mk.HeaderText = "Mật khẩu";
            this.mk.MinimumWidth = 6;
            this.mk.Name = "mk";
            this.mk.Width = 125;
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
            this.menuStrip1.Size = new System.Drawing.Size(678, 30);
            this.menuStrip1.TabIndex = 65;
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
            this.thôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSinhViênToolStripMenuItem_Click);
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
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExit.Location = new System.Drawing.Point(517, 177);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(95, 61);
            this.btExit.TabIndex = 64;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(395, 177);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 63);
            this.btDelete.TabIndex = 63;
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
            this.btEdit.Location = new System.Drawing.Point(517, 110);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 63);
            this.btEdit.TabIndex = 62;
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
            this.btNew.Location = new System.Drawing.Point(395, 110);
            this.btNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(95, 63);
            this.btNew.TabIndex = 61;
            this.btNew.Text = "Thêm";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(364, -5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 35);
            this.label4.TabIndex = 60;
            this.label4.Text = "HỆ THỐNG GIẢNG VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbmk);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 185);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mật khẩu: ";
            // 
            // tbmk
            // 
            this.tbmk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbmk.Location = new System.Drawing.Point(127, 130);
            this.tbmk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(205, 27);
            this.tbmk.TabIndex = 51;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbId.Location = new System.Drawing.Point(127, 44);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(205, 27);
            this.tbId.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên: ";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbName.Location = new System.Drawing.Point(127, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 27);
            this.tbName.TabIndex = 47;
            // 
            // TTAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvTTAdmin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.label4);
            this.Name = "TTAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTAccount";
            this.Load += new System.EventHandler(this.TTAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTAdmin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTTAdmin;
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
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
    }
}