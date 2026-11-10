namespace ProjectTaskManagement.GUI
{
    partial class frmPhanCong
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
            this.grpCongViec = new System.Windows.Forms.GroupBox();
            this.lblMaTask = new System.Windows.Forms.Label();
            this.lblMaDuAn = new System.Windows.Forms.Label();
            this.lblTenTask = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblHanNop = new System.Windows.Forms.Label();
            this.lblDoUuTien = new System.Windows.Forms.Label();
            this.txtMaTask = new System.Windows.Forms.TextBox();
            this.txtTenTask = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.cboMaDuAn = new System.Windows.Forms.ComboBox();
            this.cboDoUuTien = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.dtpHanNop = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvCongViec = new System.Windows.Forms.DataGridView();
            this.grpCongViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCongViec
            // 
            this.grpCongViec.Controls.Add(this.txtTimKiem);
            this.grpCongViec.Controls.Add(this.btnTimKiem);
            this.grpCongViec.Controls.Add(this.btnLamMoi);
            this.grpCongViec.Controls.Add(this.btnXoa);
            this.grpCongViec.Controls.Add(this.btnSua);
            this.grpCongViec.Controls.Add(this.btnThem);
            this.grpCongViec.Controls.Add(this.dtpHanNop);
            this.grpCongViec.Controls.Add(this.lblTrangThai);
            this.grpCongViec.Controls.Add(this.cboTrangThai);
            this.grpCongViec.Controls.Add(this.cboDoUuTien);
            this.grpCongViec.Controls.Add(this.cboMaDuAn);
            this.grpCongViec.Controls.Add(this.txtMoTa);
            this.grpCongViec.Controls.Add(this.txtTenTask);
            this.grpCongViec.Controls.Add(this.txtMaTask);
            this.grpCongViec.Controls.Add(this.lblDoUuTien);
            this.grpCongViec.Controls.Add(this.lblHanNop);
            this.grpCongViec.Controls.Add(this.lblMoTa);
            this.grpCongViec.Controls.Add(this.lblTenTask);
            this.grpCongViec.Controls.Add(this.lblMaDuAn);
            this.grpCongViec.Controls.Add(this.lblMaTask);
            this.grpCongViec.Location = new System.Drawing.Point(20, 60);
            this.grpCongViec.Name = "grpCongViec";
            this.grpCongViec.Size = new System.Drawing.Size(1040, 270);
            this.grpCongViec.TabIndex = 0;
            this.grpCongViec.TabStop = false;
            this.grpCongViec.Text = "THÔNG TIN CÔNG VIỆC";
            // 
            // lblMaTask
            // 
            this.lblMaTask.AutoSize = true;
            this.lblMaTask.Location = new System.Drawing.Point(34, 56);
            this.lblMaTask.Name = "lblMaTask";
            this.lblMaTask.Size = new System.Drawing.Size(101, 20);
            this.lblMaTask.TabIndex = 0;
            this.lblMaTask.Text = "Mã công việc";
            // 
            // lblMaDuAn
            // 
            this.lblMaDuAn.AutoSize = true;
            this.lblMaDuAn.Location = new System.Drawing.Point(513, 58);
            this.lblMaDuAn.Name = "lblMaDuAn";
            this.lblMaDuAn.Size = new System.Drawing.Size(52, 20);
            this.lblMaDuAn.TabIndex = 1;
            this.lblMaDuAn.Text = "Dự án";
            // 
            // lblTenTask
            // 
            this.lblTenTask.AutoSize = true;
            this.lblTenTask.Location = new System.Drawing.Point(34, 115);
            this.lblTenTask.Name = "lblTenTask";
            this.lblTenTask.Size = new System.Drawing.Size(106, 20);
            this.lblTenTask.TabIndex = 2;
            this.lblTenTask.Text = "Tên công việc";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(516, 112);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(49, 20);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblHanNop
            // 
            this.lblHanNop.AutoSize = true;
            this.lblHanNop.Location = new System.Drawing.Point(34, 174);
            this.lblHanNop.Name = "lblHanNop";
            this.lblHanNop.Size = new System.Drawing.Size(70, 20);
            this.lblHanNop.TabIndex = 4;
            this.lblHanNop.Text = "Hạn nộp";
            // 
            // lblDoUuTien
            // 
            this.lblDoUuTien.AutoSize = true;
            this.lblDoUuTien.Location = new System.Drawing.Point(513, 176);
            this.lblDoUuTien.Name = "lblDoUuTien";
            this.lblDoUuTien.Size = new System.Drawing.Size(82, 20);
            this.lblDoUuTien.TabIndex = 5;
            this.lblDoUuTien.Text = "Độ ưu tiên";
            // 
            // txtMaTask
            // 
            this.txtMaTask.Location = new System.Drawing.Point(148, 50);
            this.txtMaTask.Name = "txtMaTask";
            this.txtMaTask.ReadOnly = true;
            this.txtMaTask.Size = new System.Drawing.Size(221, 26);
            this.txtMaTask.TabIndex = 6;
            this.txtMaTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenTask
            // 
            this.txtTenTask.Location = new System.Drawing.Point(148, 112);
            this.txtTenTask.Name = "txtTenTask";
            this.txtTenTask.Size = new System.Drawing.Size(309, 26);
            this.txtTenTask.TabIndex = 7;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(611, 115);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(254, 26);
            this.txtMoTa.TabIndex = 8;
            // 
            // cboMaDuAn
            // 
            this.cboMaDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDuAn.FormattingEnabled = true;
            this.cboMaDuAn.Location = new System.Drawing.Point(611, 56);
            this.cboMaDuAn.Name = "cboMaDuAn";
            this.cboMaDuAn.Size = new System.Drawing.Size(254, 28);
            this.cboMaDuAn.TabIndex = 9;
            // 
            // cboDoUuTien
            // 
            this.cboDoUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoUuTien.FormattingEnabled = true;
            this.cboDoUuTien.Location = new System.Drawing.Point(611, 172);
            this.cboDoUuTien.Name = "cboDoUuTien";
            this.cboDoUuTien.Size = new System.Drawing.Size(254, 28);
            this.cboDoUuTien.TabIndex = 10;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(148, 228);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(221, 28);
            this.cboTrangThai.TabIndex = 11;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(54, 236);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 20);
            this.lblTrangThai.TabIndex = 12;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // dtpHanNop
            // 
            this.dtpHanNop.Location = new System.Drawing.Point(148, 170);
            this.dtpHanNop.Name = "dtpHanNop";
            this.dtpHanNop.ShowCheckBox = true;
            this.dtpHanNop.Size = new System.Drawing.Size(309, 26);
            this.dtpHanNop.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(385, 216);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(491, 216);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(597, 216);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(703, 216);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(800, 216);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 40);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(906, 230);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(128, 26);
            this.txtTimKiem.TabIndex = 19;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dgvCongViec
            // 
            this.dgvCongViec.AllowUserToAddRows = false;
            this.dgvCongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongViec.Location = new System.Drawing.Point(20, 370);
            this.dgvCongViec.MultiSelect = false;
            this.dgvCongViec.Name = "dgvCongViec";
            this.dgvCongViec.ReadOnly = true;
            this.dgvCongViec.RowHeadersWidth = 62;
            this.dgvCongViec.RowTemplate.Height = 28;
            this.dgvCongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongViec.Size = new System.Drawing.Size(1040, 300);
            this.dgvCongViec.TabIndex = 1;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 694);
            this.Controls.Add(this.dgvCongViec);
            this.Controls.Add(this.grpCongViec);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ CÔNG VIỆC";
            this.grpCongViec.ResumeLayout(false);
            this.grpCongViec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCongViec;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenTask;
        private System.Windows.Forms.TextBox txtMaTask;
        private System.Windows.Forms.Label lblDoUuTien;
        private System.Windows.Forms.Label lblHanNop;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTenTask;
        private System.Windows.Forms.Label lblMaDuAn;
        private System.Windows.Forms.Label lblMaTask;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboDoUuTien;
        private System.Windows.Forms.ComboBox cboMaDuAn;
        private System.Windows.Forms.DateTimePicker dtpHanNop;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvCongViec;
    }
}