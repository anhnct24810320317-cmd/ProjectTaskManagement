using System;
using System.Data;
using System.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL
{
    public class ThanhVienDAL
    {
        // LAY DANH SACH THANH VIEN
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "SELECT * FROM ThanhVien";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(dt);
            }

            return dt;
        }

        // THEM THANH VIEN
        public bool Insert(ThanhVienDTO tv)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"INSERT INTO ThanhVien
                    (HoTen, Email, ChuyenMon)
                    VALUES
                    (@HoTen, @Email, @ChuyenMon)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@HoTen", tv.HoTen);

                cmd.Parameters.AddWithValue("@Email",
                    (object)tv.Email ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@ChuyenMon",
                    (object)tv.ChuyenMon ?? DBNull.Value);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // SUA THANH VIEN
        public bool Update(ThanhVienDTO tv)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"UPDATE ThanhVien SET
                    HoTen = @HoTen,
                    Email = @Email,
                    ChuyenMon = @ChuyenMon
                    WHERE MaThanhVien = @MaThanhVien";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaThanhVien",
                    tv.MaThanhVien);

                cmd.Parameters.AddWithValue("@HoTen", tv.HoTen);

                cmd.Parameters.AddWithValue("@Email",
                    (object)tv.Email ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@ChuyenMon",
                    (object)tv.ChuyenMon ?? DBNull.Value);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // XOA THANH VIEN
        public bool Delete(int maThanhVien)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"DELETE FROM ThanhVien
                               WHERE MaThanhVien = @MaThanhVien";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@MaThanhVien", maThanhVien);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TIM KIEM THANH VIEN
        public DataTable Search(string hoTen)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"SELECT * FROM ThanhVien
                               WHERE HoTen LIKE @HoTen";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@HoTen", "%" + hoTen + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}