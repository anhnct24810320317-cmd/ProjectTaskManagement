using System;
using System.Data;
using System.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL
{
    public class CongViecDAL
    {
        // LAY DANH SACH CONG VIEC
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT
                        CV.MaTask,
                        CV.MaDuAn,
                        DA.TenDuAn,
                        CV.TenTask,
                        CV.MoTa,
                        CV.HanNop,
                        CV.DoUuTien,
                        CV.TrangThai
                    FROM CongViec CV
                    INNER JOIN DuAn DA
                    ON CV.MaDuAn = DA.MaDuAn";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(dt);
            }

            return dt;
        }

        // THEM CONG VIEC
        public bool Insert(CongViecDTO cv)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"INSERT INTO CongViec
                    (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai)
                    VALUES
                    (@MaDuAn, @TenTask, @MoTa, @HanNop,
                     @DoUuTien, @TrangThai)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaDuAn", cv.MaDuAn);
                cmd.Parameters.AddWithValue("@TenTask", cv.TenTask);

                cmd.Parameters.AddWithValue("@MoTa",
                    (object)cv.MoTa ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@HanNop",
                    (object)cv.HanNop ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@DoUuTien",
                    (object)cv.DoUuTien ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@TrangThai",
                    (object)cv.TrangThai ?? DBNull.Value);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // SUA CONG VIEC
        public bool Update(CongViecDTO cv)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"UPDATE CongViec SET
                    MaDuAn = @MaDuAn,
                    TenTask = @TenTask,
                    MoTa = @MoTa,
                    HanNop = @HanNop,
                    DoUuTien = @DoUuTien,
                    TrangThai = @TrangThai
                    WHERE MaTask = @MaTask";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaTask", cv.MaTask);
                cmd.Parameters.AddWithValue("@MaDuAn", cv.MaDuAn);
                cmd.Parameters.AddWithValue("@TenTask", cv.TenTask);

                cmd.Parameters.AddWithValue("@MoTa",
                    (object)cv.MoTa ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@HanNop",
                    (object)cv.HanNop ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@DoUuTien",
                    (object)cv.DoUuTien ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@TrangThai",
                    (object)cv.TrangThai ?? DBNull.Value);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // XOA CONG VIEC
        public bool Delete(int maTask)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "DELETE FROM CongViec WHERE MaTask = @MaTask";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaTask", maTask);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TIM KIEM CONG VIEC
        public DataTable Search(string tenTask)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT
                        CV.MaTask,
                        CV.MaDuAn,
                        DA.TenDuAn,
                        CV.TenTask,
                        CV.MoTa,
                        CV.HanNop,
                        CV.DoUuTien,
                        CV.TrangThai
                    FROM CongViec CV
                    INNER JOIN DuAn DA
                    ON CV.MaDuAn = DA.MaDuAn
                    WHERE CV.TenTask LIKE @TenTask";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@TenTask", "%" + tenTask + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}