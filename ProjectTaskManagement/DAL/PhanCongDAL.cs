using System;
using System.Data;
using System.Data.SqlClient;
using ProjectTaskManagement.DTO;

namespace ProjectTaskManagement.DAL
{
    public class PhanCongDAL
    {
        // LAY DANH SACH PHAN CONG
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"
                    SELECT
                        PC.MaTask,
                        CV.TenTask,
                        PC.MaThanhVien,
                        TV.HoTen,
                        PC.NgayGiao
                    FROM PhanCong PC
                    INNER JOIN CongViec CV
                    ON PC.MaTask = CV.MaTask
                    INNER JOIN ThanhVien TV
                    ON PC.MaThanhVien = TV.MaThanhVien";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(dt);
            }

            return dt;
        }

        // THEM PHAN CONG
        public bool Insert(PhanCongDTO pc)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"INSERT INTO PhanCong
                    (MaTask, MaThanhVien)
                    VALUES
                    (@MaTask, @MaThanhVien)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaTask", pc.MaTask);

                cmd.Parameters.AddWithValue(
                    "@MaThanhVien", pc.MaThanhVien);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // XOA PHAN CONG
        public bool Delete(int maTask, int maThanhVien)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = @"DELETE FROM PhanCong
                    WHERE MaTask = @MaTask
                    AND MaThanhVien = @MaThanhVien";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaTask", maTask);

                cmd.Parameters.AddWithValue(
                    "@MaThanhVien", maThanhVien);

                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}