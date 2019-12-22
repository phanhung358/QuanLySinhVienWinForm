namespace QuanLySinhVien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.tenlophocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoaLHP = new System.Windows.Forms.ToolStripButton();
            this.btnThemLHP = new System.Windows.Forms.ToolStripButton();
            this.btnSuaLHP = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSoLuongDK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinMax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaLHP = new System.Windows.Forms.Label();
            this.lblGiaoVienPhuTrach = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoaSV = new System.Windows.Forms.ToolStripButton();
            this.btnThemSV = new System.Windows.Forms.ToolStripButton();
            this.btnSuaSV = new System.Windows.Forms.ToolStripButton();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.masinhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLopHocPhan = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopHocPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn môn học:";
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.Location = new System.Drawing.Point(135, 22);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(264, 24);
            this.cbxMonHoc.TabIndex = 1;
            this.cbxMonHoc.SelectedIndexChanged += new System.EventHandler(this.CbxMonHoc_SelectedIndexChanged);
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.AllowUserToAddRows = false;
            this.dgvLopHocPhan.AllowUserToDeleteRows = false;
            this.dgvLopHocPhan.AutoGenerateColumns = false;
            this.dgvLopHocPhan.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenlophocphan});
            this.dgvLopHocPhan.DataSource = this.bdsLopHocPhan;
            this.dgvLopHocPhan.Location = new System.Drawing.Point(0, 97);
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.ReadOnly = true;
            this.dgvLopHocPhan.RowHeadersVisible = false;
            this.dgvLopHocPhan.RowHeadersWidth = 51;
            this.dgvLopHocPhan.RowTemplate.Height = 24;
            this.dgvLopHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHocPhan.Size = new System.Drawing.Size(399, 613);
            this.dgvLopHocPhan.TabIndex = 2;
            this.dgvLopHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLopHocPhan_CellClick);
            // 
            // tenlophocphan
            // 
            this.tenlophocphan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenlophocphan.DataPropertyName = "tenlophocphan";
            this.tenlophocphan.HeaderText = "Tên lớp học phần";
            this.tenlophocphan.MinimumWidth = 6;
            this.tenlophocphan.Name = "tenlophocphan";
            this.tenlophocphan.ReadOnly = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(399, 26);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 65);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(399, 26);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoaLHP,
            this.btnThemLHP,
            this.btnSuaLHP});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(399, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 23);
            this.toolStripLabel1.Text = "Lớp học phần";
            // 
            // btnXoaLHP
            // 
            this.btnXoaLHP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLHP.Image")));
            this.btnXoaLHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLHP.Name = "btnXoaLHP";
            this.btnXoaLHP.Size = new System.Drawing.Size(59, 23);
            this.btnXoaLHP.Text = "Xóa";
            // 
            // btnThemLHP
            // 
            this.btnThemLHP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLHP.Image")));
            this.btnThemLHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLHP.Name = "btnThemLHP";
            this.btnThemLHP.Size = new System.Drawing.Size(70, 23);
            this.btnThemLHP.Text = "Thêm";
            // 
            // btnSuaLHP
            // 
            this.btnSuaLHP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLHP.Image")));
            this.btnSuaLHP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaLHP.Name = "btnSuaLHP";
            this.btnSuaLHP.Size = new System.Drawing.Size(58, 23);
            this.btnSuaLHP.Text = "Sửa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(683, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSoLuongDK);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblMinMax);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMaLHP);
            this.panel1.Controls.Add(this.lblGiaoVienPhuTrach);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(407, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 151);
            this.panel1.TabIndex = 4;
            // 
            // lblSoLuongDK
            // 
            this.lblSoLuongDK.AutoSize = true;
            this.lblSoLuongDK.Location = new System.Drawing.Point(214, 104);
            this.lblSoLuongDK.Name = "lblSoLuongDK";
            this.lblSoLuongDK.Size = new System.Drawing.Size(24, 17);
            this.lblSoLuongDK.TabIndex = 0;
            this.lblSoLuongDK.Text = "aa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng sinh viên đăng ký:";
            // 
            // lblMinMax
            // 
            this.lblMinMax.AutoSize = true;
            this.lblMinMax.Location = new System.Drawing.Point(214, 62);
            this.lblMinMax.Name = "lblMinMax";
            this.lblMinMax.Size = new System.Drawing.Size(24, 17);
            this.lblMinMax.TabIndex = 0;
            this.lblMinMax.Text = "aa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Định mức sinh viên(min/max):";
            // 
            // lblMaLHP
            // 
            this.lblMaLHP.AutoSize = true;
            this.lblMaLHP.Location = new System.Drawing.Point(214, 20);
            this.lblMaLHP.Name = "lblMaLHP";
            this.lblMaLHP.Size = new System.Drawing.Size(24, 17);
            this.lblMaLHP.TabIndex = 0;
            this.lblMaLHP.Text = "aa";
            // 
            // lblGiaoVienPhuTrach
            // 
            this.lblGiaoVienPhuTrach.AutoSize = true;
            this.lblGiaoVienPhuTrach.Location = new System.Drawing.Point(494, 20);
            this.lblGiaoVienPhuTrach.Name = "lblGiaoVienPhuTrach";
            this.lblGiaoVienPhuTrach.Size = new System.Drawing.Size(47, 17);
            this.lblGiaoVienPhuTrach.TabIndex = 0;
            this.lblGiaoVienPhuTrach.Text = "tên gv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giáo viên phụ trách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã lớp học phần:";
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(693, 29);
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(407, 205);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(693, 29);
            this.toolStripContainer2.TabIndex = 5;
            this.toolStripContainer2.Text = "toolStripContainer2";
            this.toolStripContainer2.TopToolStripPanelVisible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnXoaSV,
            this.btnThemSV,
            this.btnSuaSV});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(693, 29);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(138, 26);
            this.toolStripLabel2.Text = "Danh sách sinh viên";
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSV.Image")));
            this.btnXoaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(59, 26);
            this.btnXoaSV.Text = "Xóa";
            // 
            // btnThemSV
            // 
            this.btnThemSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThemSV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSV.Image")));
            this.btnThemSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(141, 26);
            this.btnThemSV.Text = "Đăng ký vào lớp";
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSuaSV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSV.Image")));
            this.btnSuaSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(58, 26);
            this.btnSuaSV.Text = "Sửa";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvien,
            this.hodem,
            this.ten,
            this.ngaysinh,
            this.quequan});
            this.dgvSinhVien.DataSource = this.bdsSinhVien;
            this.dgvSinhVien.Location = new System.Drawing.Point(408, 237);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(693, 473);
            this.dgvSinhVien.TabIndex = 6;
            // 
            // masinhvien
            // 
            this.masinhvien.DataPropertyName = "masinhvien";
            this.masinhvien.HeaderText = "Mã sinh viên";
            this.masinhvien.MinimumWidth = 6;
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.ReadOnly = true;
            this.masinhvien.Width = 110;
            // 
            // hodem
            // 
            this.hodem.DataPropertyName = "hodem";
            this.hodem.HeaderText = "Họ đệm";
            this.hodem.MinimumWidth = 6;
            this.hodem.Name = "hodem";
            this.hodem.ReadOnly = true;
            this.hodem.Width = 110;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 49;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Width = 110;
            // 
            // quequan
            // 
            this.quequan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê Quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 714);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.dgvLopHocPhan);
            this.Controls.Add(this.cbxMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopHocPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLopHocPhan;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnXoaLHP;
        private System.Windows.Forms.ToolStripButton btnThemLHP;
        private System.Windows.Forms.ToolStripButton btnSuaLHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSoLuongDK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaLHP;
        private System.Windows.Forms.Label lblGiaoVienPhuTrach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnXoaSV;
        private System.Windows.Forms.ToolStripButton btnThemSV;
        private System.Windows.Forms.ToolStripButton btnSuaSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.BindingSource bdsLopHocPhan;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlophocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
    }
}

