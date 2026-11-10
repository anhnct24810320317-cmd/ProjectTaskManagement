
using System;
using System.Data;
using System.Windows.Forms;
using ProjectTaskManagement.DTO;
using ProjectTaskManagement.BUS;

namespace ProjectTaskManagement.GUI
{
    public partial class frmCongViec : Form
    {
        CongViecBUS bus = new CongViecBUS();
        DuAnBUS duAnBus = new DuAnBUS();

        public frmCongViec()
        {
            InitializeComponent();

            Load += frmCongViec_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            dgvCongViec.CellClick += dgvCongViec_CellClick;
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            cboDoUuTien.Items.Clear();
            cboDoUuTien.Items.AddRange(new object[]
            {
                "Thấp", "Trung bình", "Cao"
            });

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[]
            {
                "Chưa thực hiện", "Đang thực hiện", "Hoàn thành"
            });

            LoadDuAn();
            LoadCongViec();
            LamMoi();
        }

        private void LoadDuAn()
        {
            cboMaDuAn.DataSource = duAnBus.GetAll();
            cboMaDuAn.DisplayMember = "TenDuAn";
            cboMaDuAn.ValueMember = "MaDuAn";
            cboMaDuAn.SelectedIndex = -1;
        }

        private void LoadCongViec()
        {
            dgvCongViec.DataSource = bus.GetAll();
        }

        private void LamMoi()
        {
            txtMaTask.Clear();
            txtTenTask.Clear();
            txtMoTa.Clear();
            txtTimKiem.Clear();

            cboMaDuAn.SelectedIndex = -1;
            cboDoUuTien.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            dtpHanNop.Value = DateTime.Today;
            dtpHanNop.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTask.Text.Trim() == "" ||
                cboMaDuAn.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập tên công việc và chọn dự án!");
                return;
            }

            CongViecDTO cv = new CongViecDTO();
            cv.MaDuAn = Convert.ToInt32(cboMaDuAn.SelectedValue);
            cv.TenTask = txtTenTask.Text.Trim();
            cv.MoTa = txtMoTa.Text.Trim();
            cv.HanNop = dtpHanNop.Checked
                ? dtpHanNop.Value : (DateTime?)null;
            cv.DoUuTien = cboDoUuTien.Text;
            cv.TrangThai = cboTrangThai.Text;

            bus.Insert(cv);
            LoadCongViec();
            LamMoi();
            MessageBox.Show("Thêm công việc thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTask.Text == "" ||
                txtTenTask.Text.Trim() == "" ||
                cboMaDuAn.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn công việc và nhập đủ thông tin!");
                return;
            }

            CongViecDTO cv = new CongViecDTO();
            cv.MaTask = Convert.ToInt32(txtMaTask.Text);
            cv.MaDuAn = Convert.ToInt32(cboMaDuAn.SelectedValue);
            cv.TenTask = txtTenTask.Text.Trim();
            cv.MoTa = txtMoTa.Text.Trim();
            cv.HanNop = dtpHanNop.Checked
                ? dtpHanNop.Value : (DateTime?)null;
            cv.DoUuTien = cboDoUuTien.Text;
            cv.TrangThai = cboTrangThai.Text;

            bus.Update(cv);
            LoadCongViec();
            LamMoi();
            MessageBox.Show("Sửa công việc thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTask.Text == "")
            {
                MessageBox.Show("Hãy chọn công việc cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa công việc này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                bus.Delete(Convert.ToInt32(txtMaTask.Text));
                LoadCongViec();
                LamMoi();
                MessageBox.Show("Xóa công việc thành công!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadCongViec();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvCongViec.DataSource = bus.Search(txtTimKiem.Text.Trim());
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCongViec.Rows[e.RowIndex];

            txtMaTask.Text = row.Cells["MaTask"].Value.ToString();
            txtTenTask.Text = row.Cells["TenTask"].Value.ToString();
            txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();

            cboMaDuAn.SelectedValue =
                Convert.ToInt32(row.Cells["MaDuAn"].Value);

            cboDoUuTien.Text = row.Cells["DoUuTien"].Value?.ToString();
            cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();

            if (row.Cells["HanNop"].Value == DBNull.Value)
            {
                dtpHanNop.Checked = false;
            }
            else
            {
                dtpHanNop.Value =
                    Convert.ToDateTime(row.Cells["HanNop"].Value);
                dtpHanNop.Checked = true;
            }
        }
    }
}
