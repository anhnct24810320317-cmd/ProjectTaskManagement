using System.Data;
using ProjectTaskManagement.DTO;
using ProjectTaskManagement.DAL;

namespace ProjectTaskManagement.BUS
{
    public class ThanhVienBUS
    {
        ThanhVienDAL dal = new ThanhVienDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(ThanhVienDTO tv)
        {
            if (string.IsNullOrWhiteSpace(tv.HoTen))
                return false;

            return dal.Insert(tv);
        }

        public bool Update(ThanhVienDTO tv)
        {
            if (tv.MaThanhVien <= 0 ||
                string.IsNullOrWhiteSpace(tv.HoTen))
                return false;

            return dal.Update(tv);
        }

        public bool Delete(int maThanhVien)
        {
            if (maThanhVien <= 0)
                return false;

            return dal.Delete(maThanhVien);
        }

        public DataTable Search(string hoTen)
        {
            return dal.Search(hoTen);
        }
    }
}