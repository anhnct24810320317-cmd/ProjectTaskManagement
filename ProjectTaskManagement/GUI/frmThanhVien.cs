
using System;
using System.Windows.Forms;
using ProjectTaskManagement.DTO;
using ProjectTaskManagement.BUS;

namespace ProjectTaskManagement.GUI
{
    public partial class frmThanhVien : Form
    {
        ThanhVienBUS bus = new ThanhVienBUS();

        public frmThanhVien()
        {
            InitializeComponent();

            Load += frmThanhVien_Load;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            dgvThanhVien.CellClick += dgvThanhVien_CellClick;
        }

        // KHI MO FORM
        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            txtMaTV.ReadOnly = true;
            HienThiDanhSach();
            LamMoi();
        }

        // HIEN THI DANH SACH
        private void HienThiDanhSach()
        {
            dgvThanhVien.DataSource = bus.GetAll();

            dgvThanhVien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // LAM MOI
        private void LamMoi()
        {
            txtMaTV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtChuyenMon.Clear();
            txtHoTen.Focus();
        }

        // LAY DU LIEU
        private ThanhVienDTO LayDuLieu()
        {
            ThanhVienDTO tv = new ThanhVienDTO();

            tv.HoTen = txtHoTen.Text.Trim();
            tv.Email = string.IsNullOrWhiteSpace(txtEmail.Text)
                ? null : txtEmail.Text.Trim();
            tv.ChuyenMon = txtChuyenMon.Text.Trim();

            return tv;
        }

        // KIEM TRA
        private bool KiemTra()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(
                    txtEmail.Text.Trim(),
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        // THEM
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTra()) return;

                if (bus.Insert(LayDuLieu()))
                {
                    MessageBox.Show("Thêm thành viên thành công!");
                    HienThiDanhSach();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // SUA
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaTV.Text))
                {
                    MessageBox.Show("Vui lòng chọn thành viên cần sửa!");
                    return;
                }

                if (!KiemTra()) return;

                ThanhVienDTO tv = LayDuLieu();
                tv.MaThanhVien = int.Parse(txtMaTV.Text);

                if (bus.Update(tv))
                {
                    MessageBox.Show("Sửa thành viên thành công!");
                    HienThiDanhSach();
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // XOA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaTV.Text))
                {
                    MessageBox.Show("Vui lòng chọn thành viên cần xóa!");
                    return;
                }

                DialogResult kq = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa thành viên này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (kq == DialogResult.Yes)
                {
                    int ma = int.Parse(txtMaTV.Text);

                    if (bus.Delete(ma))
                    {
                        MessageBox.Show("Xóa thành viên thành công!");
                        HienThiDanhSach();
                        LamMoi();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // LAM MOI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            HienThiDanhSach();
        }

        // TIM KIEM
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvThanhVien.DataSource =
                    bus.Search(txtTimKiem.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // CHON DONG
        private void dgvThanhVien_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThanhVien.Rows[e.RowIndex];

                txtMaTV.Text =
                    Convert.ToString(row.Cells["MaThanhVien"].Value);

                txtHoTen.Text =
                    Convert.ToString(row.Cells["HoTen"].Value);

                txtEmail.Text =
                    Convert.ToString(row.Cells["Email"].Value);

                txtChuyenMon.Text =
                    Convert.ToString(row.Cells["ChuyenMon"].Value);
            }
        }
    }
}
