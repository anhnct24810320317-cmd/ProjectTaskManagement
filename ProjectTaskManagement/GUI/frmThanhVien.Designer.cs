namespace ProjectTaskManagement.GUI
{
    partial class frmThanhVien
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
            this.grpThanhVien = new System.Windows.Forms.GroupBox();
            this.lblMaTV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblChuyenMon = new System.Windows.Forms.Label();
            this.txtMaTV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtChuyenMon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.grpThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThanhVien
            // 
            this.grpThanhVien.Controls.Add(this.txtTimKiem);
            this.grpThanhVien.Controls.Add(this.btnTimKiem);
            this.grpThanhVien.Controls.Add(this.btnLamMoi);
            this.grpThanhVien.Controls.Add(this.btnXoa);
            this.grpThanhVien.Controls.Add(this.btnSua);
            this.grpThanhVien.Controls.Add(this.btnThem);
            this.grpThanhVien.Controls.Add(this.txtChuyenMon);
            this.grpThanhVien.Controls.Add(this.txtEmail);
            this.grpThanhVien.Controls.Add(this.txtHoTen);
            this.grpThanhVien.Controls.Add(this.txtMaTV);
            this.grpThanhVien.Controls.Add(this.lblChuyenMon);
            this.grpThanhVien.Controls.Add(this.lblEmail);
            this.grpThanhVien.Controls.Add(this.lblHoTen);
            this.grpThanhVien.Controls.Add(this.lblMaTV);
            this.grpThanhVien.Location = new System.Drawing.Point(20, 75);
            this.grpThanhVien.Name = "grpThanhVien";
            this.grpThanhVien.Size = new System.Drawing.Size(1040, 200);
            this.grpThanhVien.TabIndex = 0;
            this.grpThanhVien.TabStop = false;
            this.grpThanhVien.Text = "THÔNG TIN THÀNH VIÊN";
            // 
            // lblMaTV
            // 
            this.lblMaTV.AutoSize = true;
            this.lblMaTV.Location = new System.Drawing.Point(36, 42);
            this.lblMaTV.Name = "lblMaTV";
            this.lblMaTV.Size = new System.Drawing.Size(108, 20);
            this.lblMaTV.TabIndex = 0;
            this.lblMaTV.Text = "Mã thành viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(467, 42);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(59, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblChuyenMon
            // 
            this.lblChuyenMon.AutoSize = true;
            this.lblChuyenMon.Location = new System.Drawing.Point(467, 103);
            this.lblChuyenMon.Name = "lblChuyenMon";
            this.lblChuyenMon.Size = new System.Drawing.Size(98, 20);
            this.lblChuyenMon.TabIndex = 3;
            this.lblChuyenMon.Text = "Chuyên môn";
            // 
            // txtMaTV
            // 
            this.txtMaTV.Location = new System.Drawing.Point(188, 36);
            this.txtMaTV.Name = "txtMaTV";
            this.txtMaTV.ReadOnly = true;
            this.txtMaTV.Size = new System.Drawing.Size(201, 26);
            this.txtMaTV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(575, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(288, 26);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(188, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtChuyenMon
            // 
            this.txtChuyenMon.Location = new System.Drawing.Point(575, 97);
            this.txtChuyenMon.Name = "txtChuyenMon";
            this.txtChuyenMon.Size = new System.Drawing.Size(288, 26);
            this.txtChuyenMon.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(63, 139);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(188, 139);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(316, 139);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(471, 139);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(594, 139);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 40);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(724, 146);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(199, 26);
            this.txtTimKiem.TabIndex = 13;
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.AllowUserToAddRows = false;
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Location = new System.Drawing.Point(20, 350);
            this.dgvThanhVien.MultiSelect = false;
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.RowHeadersWidth = 62;
            this.dgvThanhVien.RowTemplate.Height = 28;
            this.dgvThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhVien.Size = new System.Drawing.Size(1040, 290);
            this.dgvThanhVien.TabIndex = 1;
            // 
            // frmThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.dgvThanhVien);
            this.Controls.Add(this.grpThanhVien);
            this.Name = "frmThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ THÀNH VIÊN";
            this.grpThanhVien.ResumeLayout(false);
            this.grpThanhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThanhVien;
        private System.Windows.Forms.Label lblChuyenMon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaTV;
        private System.Windows.Forms.TextBox txtChuyenMon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaTV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvThanhVien;
    }
}