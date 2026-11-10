using System;
using System.Data;
using System.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL
{
    public class DuAnDAL
    {
        // 1. LAY DANH SACH DU AN
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "SELECT * FROM DuAn";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(dt);
            }

            return dt;
        }

        // 2. THEM DU AN
        public bool Insert(DuAnDTO da)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"INSERT INTO DuAn
                    (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai)
                    VALUES
                    (@TenDuAn, @NgayBatDau, @NgayKetThuc, @TrangThai)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenDuAn", da.TenDuAn);

                cmd.Parameters.AddWithValue("@NgayBatDau",
                    (object)da.NgayBatDau ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@NgayKetThuc",
                    (object)da.NgayKetThuc ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@TrangThai",
                    (object)da.TrangThai ?? DBNull.Value);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 3. SUA DU AN
        public bool Update(DuAnDTO da)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"UPDATE DuAn SET
                    TenDuAn = @TenDuAn,
                    NgayBatDau = @NgayBatDau,
                    NgayKetThuc = @NgayKetThuc,
                    TrangThai = @TrangThai
                    WHERE MaDuAn = @MaDuAn";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaDuAn", da.MaDuAn);
                cmd.Parameters.AddWithValue("@TenDuAn", da.TenDuAn);

                cmd.Parameters.AddWithValue("@NgayBatDau",
                    (object)da.NgayBatDau ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@NgayKetThuc",
                    (object)da.NgayKetThuc ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@TrangThai",
                    (object)da.TrangThai ?? DBNull.Value);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 4. XOA DU AN
        public bool Delete(int maDuAn)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "DELETE FROM DuAn WHERE MaDuAn = @MaDuAn";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 5. TIM KIEM DU AN
        public DataTable Search(string tenDuAn)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"SELECT * FROM DuAn
                               WHERE TenDuAn LIKE @TenDuAn";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@TenDuAn", "%" + tenDuAn + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}