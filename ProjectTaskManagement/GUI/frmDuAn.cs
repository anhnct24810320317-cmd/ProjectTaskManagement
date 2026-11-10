
using System;
using System.Data;
using System.Windows.Forms;
using ProjectTaskManagement.DTO;
using ProjectTaskManagement.BUS;

namespace ProjectTaskManagement.GUI
{
    public partial class frmDuAn : Form
    {
        DuAnBUS bus = new DuAnBUS();

        public frmDuAn()
        {
            InitializeComponent();

            Load += frmDuAn_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            dgvDuAn.CellClick += dgvDuAn_CellClick;
        }

        // KHI MO FORM
        private void frmDuAn_Load(object sender, EventArgs e)
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đang chạy");
            cboTrangThai.Items.Add("Hoàn thành");
            cboTrangThai.Items.Add("Tạm dừng");

            cboTrangThai.SelectedIndex = 0;

            txtMaDuAn.ReadOnly = true;

            HienThiDanhSach();
            LamMoi();
        }

        // HIEN THI DANH SACH DU AN
        private void HienThiDanhSach()
        {
            dgvDuAn.DataSource = bus.GetAll();

            dgvDuAn.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // LAM MOI CAC O NHAP
        private void LamMoi()
        {
            txtMaDuAn.Clear();
            txtTenDuAn.Clear();

            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;

            dtpNgayBatDau.Checked = false;
            dtpNgayKetThuc.Checked = false;

            cboTrangThai.SelectedIndex = 0;

            txtTenDuAn.Focus();
        }

        // LAY DU LIEU TU FORM
        private DuAnDTO LayDuLieu()
        {
            DuAnDTO da = new DuAnDTO();

            da.TenDuAn = txtTenDuAn.Text.Trim();

            da.NgayBatDau = dtpNgayBatDau.Checked
                ? (DateTime?)dtpNgayBatDau.Value
                : null;

            da.NgayKetThuc = dtpNgayKetThuc.Checked
                ? (DateTime?)dtpNgayKetThuc.Value
                : null;

            da.TrangThai = cboTrangThai.Text;

            return da;
        }

        // KIEM TRA DU LIEU
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtTenDuAn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dự án!");
                txtTenDuAn.Focus();
                return false;
            }

            if (dtpNgayBatDau.Checked &&
                dtpNgayKetThuc.Checked &&
                dtpNgayKetThuc.Value.Date <
                dtpNgayBatDau.Value.Date)
            {
                MessageBox.Show(
                    "Ngày kết thúc không được trước ngày bắt đầu!");
                return false;
            }

            return true;
        }

        // NUT THEM
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu())
                    return;

                DuAnDTO da = LayDuLieu();

                if (bus.Insert(da))
                {
                    MessageBox.Show("Thêm dự án thành công!");
                    HienThiDanhSach();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Thêm dự án thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // NUT SUA
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaDuAn.Text))
                {
                    MessageBox.Show("Vui lòng chọn dự án cần sửa!");
                    return;
                }

                if (!KiemTraDuLieu())
                    return;

                DuAnDTO da = LayDuLieu();
                da.MaDuAn = int.Parse(txtMaDuAn.Text);

                if (bus.Update(da))
                {
                    MessageBox.Show("Sửa dự án thành công!");
                    HienThiDanhSach();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Sửa dự án thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // NUT XOA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaDuAn.Text))
                {
                    MessageBox.Show("Vui lòng chọn dự án cần xóa!");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa dự án này không? " +
                    "Các công việc và phân công liên quan cũng sẽ bị xóa.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int ma = int.Parse(txtMaDuAn.Text);

                    if (bus.Delete(ma))
                    {
                        MessageBox.Show("Xóa dự án thành công!");
                        HienThiDanhSach();
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Xóa dự án thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // NUT LAM MOI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            HienThiDanhSach();
        }

        // NUT TIM KIEM
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDuAn.DataSource =
                    bus.Search(txtTimKiem.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // CHON DONG TREN DATAGRIDVIEW
        private void dgvDuAn_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDuAn.Rows[e.RowIndex];

                txtMaDuAn.Text =
                    Convert.ToString(row.Cells["MaDuAn"].Value);

                txtTenDuAn.Text =
                    Convert.ToString(row.Cells["TenDuAn"].Value);

                if (row.Cells["NgayBatDau"].Value != DBNull.Value)
                {
                    dtpNgayBatDau.Value =
                        Convert.ToDateTime(
                            row.Cells["NgayBatDau"].Value);

                    dtpNgayBatDau.Checked = true;
                }
                else
                {
                    dtpNgayBatDau.Checked = false;
                }

                if (row.Cells["NgayKetThuc"].Value != DBNull.Value)
                {
                    dtpNgayKetThuc.Value =
                        Convert.ToDateTime(
                            row.Cells["NgayKetThuc"].Value);

                    dtpNgayKetThuc.Checked = true;
                }
                else
                {
                    dtpNgayKetThuc.Checked = false;
                }

                cboTrangThai.Text =
                    Convert.ToString(row.Cells["TrangThai"].Value);
            }
        }
    }
}
