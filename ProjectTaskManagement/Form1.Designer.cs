namespace ProjectTaskManagement
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
            this.btnDuAn = new System.Windows.Forms.Button();
            this.btnThanhVien = new System.Windows.Forms.Button();
            this.btnCongViec = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ CÔNG VIỆC VÀ DỰ ÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDuAn
            // 
            this.btnDuAn.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDuAn.Location = new System.Drawing.Point(67, 159);
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.Size = new System.Drawing.Size(220, 100);
            this.btnDuAn.TabIndex = 1;
            this.btnDuAn.Text = "\tQuản lý dự án";
            this.btnDuAn.UseVisualStyleBackColor = false;
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThanhVien.Location = new System.Drawing.Point(527, 159);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(220, 100);
            this.btnThanhVien.TabIndex = 2;
            this.btnThanhVien.Text = "Quản lý thành viên";
            this.btnThanhVien.UseVisualStyleBackColor = false;
            // 
            // btnCongViec
            // 
            this.btnCongViec.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCongViec.Location = new System.Drawing.Point(67, 308);
            this.btnCongViec.Name = "btnCongViec";
            this.btnCongViec.Size = new System.Drawing.Size(220, 100);
            this.btnCongViec.TabIndex = 3;
            this.btnCongViec.Text = "Quản lý công việc";
            this.btnCongViec.UseVisualStyleBackColor = false;
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPhanCong.Location = new System.Drawing.Point(527, 308);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(220, 100);
            this.btnPhanCong.TabIndex = 4;
            this.btnPhanCong.Text = "Phân công công việc";
            this.btnPhanCong.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(731, 497);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 45);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.btnCongViec);
            this.Controls.Add(this.btnThanhVien);
            this.Controls.Add(this.btnDuAn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ CÔNG VIỆC VÀ DỰ ÁN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDuAn;
        private System.Windows.Forms.Button btnThanhVien;
        private System.Windows.Forms.Button btnCongViec;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnThoat;
    }
}

