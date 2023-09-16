namespace Lab3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtAvr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lblTongSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtNu = new System.Windows.Forms.TextBox();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thông tin sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.txtAvr);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblChuyenNganh);
            this.groupBox1.Controls.Add(this.lblDiemTB);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lblMaSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Checked = true;
            this.rdoNu.Location = new System.Drawing.Point(299, 129);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(54, 24);
            this.rdoNu.TabIndex = 9;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbKhoa.Location = new System.Drawing.Point(174, 218);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(238, 28);
            this.cmbKhoa.TabIndex = 9;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(174, 129);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(67, 24);
            this.rdoNam.TabIndex = 8;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtAvr
            // 
            this.txtAvr.Location = new System.Drawing.Point(174, 177);
            this.txtAvr.Name = "txtAvr";
            this.txtAvr.Size = new System.Drawing.Size(238, 26);
            this.txtAvr.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 43);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(238, 26);
            this.txtID.TabIndex = 5;
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(18, 226);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(114, 20);
            this.lblChuyenNganh.TabIndex = 4;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(18, 183);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(70, 20);
            this.lblDiemTB.TabIndex = 3;
            this.lblDiemTB.Text = "Điểm TB";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(18, 135);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(18, 94);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(18, 43);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(103, 20);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(186, 397);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 38);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Thêm/Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(337, 397);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.GioiTinh,
            this.DTB,
            this.Khoa});
            this.dgvStudent.Location = new System.Drawing.Point(533, 76);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(764, 294);
            this.dgvStudent.TabIndex = 4;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // lblTongSV
            // 
            this.lblTongSV.AutoSize = true;
            this.lblTongSV.Location = new System.Drawing.Point(877, 406);
            this.lblTongSV.Name = "lblTongSV";
            this.lblTongSV.Size = new System.Drawing.Size(71, 20);
            this.lblTongSV.TabIndex = 5;
            this.lblTongSV.Text = "Tổng SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1100, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nữ";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(1028, 406);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(55, 26);
            this.txtNam.TabIndex = 8;
            // 
            // txtNu
            // 
            this.txtNu.Location = new System.Drawing.Point(1168, 406);
            this.txtNu.Name = "txtNu";
            this.txtNu.Size = new System.Drawing.Size(55, 26);
            this.txtNu.TabIndex = 9;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 8;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 80;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DTB
            // 
            this.DTB.HeaderText = "ĐTB";
            this.DTB.MinimumWidth = 8;
            this.DTB.Name = "DTB";
            this.DTB.ReadOnly = true;
            this.DTB.Width = 80;
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 8;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 445);
            this.Controls.Add(this.txtNu);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTongSV);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtAvr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblTongSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    }
}

