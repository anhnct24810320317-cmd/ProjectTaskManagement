namespace ProjectTaskManagement.GUI
{
    partial class frmDuAn
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaDuAn = new System.Windows.Forms.Label();
            this.lblTenDuAn = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMaDuAn = new System.Windows.Forms.TextBox();
            this.txtTenDuAn = new System.Windows.Forms.TextBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Location = new System.Drawing.Point(20, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1050, 55);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ DỰ ÁN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtTimKiem);
            this.grpThongTin.Controls.Add(this.btnTimKiem);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.grpThongTin.Controls.Add(this.dtpNgayBatDau);
            this.grpThongTin.Controls.Add(this.txtTenDuAn);
            this.grpThongTin.Controls.Add(this.txtMaDuAn);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.lblNgayKetThuc);
            this.grpThongTin.Controls.Add(this.lblNgayBatDau);
            this.grpThongTin.Controls.Add(this.lblTenDuAn);
            this.grpThongTin.Controls.Add(this.lblMaDuAn);
            this.grpThongTin.Location = new System.Drawing.Point(20, 75);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1040, 210);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN DỰ ÁN";
            // 
            // lblMaDuAn
            // 
            this.lblMaDuAn.AutoSize = true;
            this.lblMaDuAn.Location = new System.Drawing.Point(32, 48);
            this.lblMaDuAn.Name = "lblMaDuAn";
            this.lblMaDuAn.Size = new System.Drawing.Size(75, 20);
            this.lblMaDuAn.TabIndex = 0;
            this.lblMaDuAn.Text = "Mã dự án";
            // 
            // lblTenDuAn
            // 
            this.lblTenDuAn.AutoSize = true;
            this.lblTenDuAn.Location = new System.Drawing.Point(525, 51);
            this.lblTenDuAn.Name = "lblTenDuAn";
            this.lblTenDuAn.Size = new System.Drawing.Size(80, 20);
            this.lblTenDuAn.TabIndex = 1;
            this.lblTenDuAn.Text = "Tên dự án";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(32, 102);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(103, 20);
            this.lblNgayBatDau.TabIndex = 2;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(525, 110);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(106, 20);
            this.lblNgayKetThuc.TabIndex = 3;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(32, 163);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 20);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // txtMaDuAn
            // 
            this.txtMaDuAn.Location = new System.Drawing.Point(151, 45);
            this.txtMaDuAn.Name = "txtMaDuAn";
            this.txtMaDuAn.ReadOnly = true;
            this.txtMaDuAn.Size = new System.Drawing.Size(296, 26);
            this.txtMaDuAn.TabIndex = 5;
            // 
            // txtTenDuAn
            // 
            this.txtTenDuAn.Location = new System.Drawing.Point(632, 48);
            this.txtTenDuAn.Name = "txtTenDuAn";
            this.txtTenDuAn.Size = new System.Drawing.Size(318, 26);
            this.txtTenDuAn.TabIndex = 6;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(151, 104);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.ShowCheckBox = true;
            this.dtpNgayBatDau.Size = new System.Drawing.Size(296, 26);
            this.dtpNgayBatDau.TabIndex = 7;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(638, 103);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.ShowCheckBox = true;
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(312, 26);
            this.dtpNgayKetThuc.TabIndex = 8;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(151, 163);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(199, 28);
            this.cboTrangThai.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(384, 153);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 40);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(500, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 40);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(616, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(732, 151);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 40);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(840, 151);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 40);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(956, 160);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(84, 26);
            this.txtTimKiem.TabIndex = 15;
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.AllowUserToAddRows = false;
            this.dgvDuAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Location = new System.Drawing.Point(20, 350);
            this.dgvDuAn.MultiSelect = false;
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.ReadOnly = true;
            this.dgvDuAn.RowHeadersWidth = 62;
            this.dgvDuAn.RowTemplate.Height = 28;
            this.dgvDuAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuAn.Size = new System.Drawing.Size(1040, 290);
            this.dgvDuAn.TabIndex = 2;
            // 
            // frmDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.dgvDuAn);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmDuAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ DỰ ÁN";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtTenDuAn;
        private System.Windows.Forms.TextBox txtMaDuAn;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblTenDuAn;
        private System.Windows.Forms.Label lblMaDuAn;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDuAn;
    }
}