using System.Data;
using ProjectTaskManagement.DTO;
using ProjectTaskManagement.DAL;

namespace ProjectTaskManagement.BUS
{
    public class PhanCongBUS
    {
        PhanCongDAL dal = new PhanCongDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(PhanCongDTO pc)
        {
            if (pc.MaTask <= 0 || pc.MaThanhVien <= 0)
                return false;

            return dal.Insert(pc);
        }

        public bool Delete(int maTask, int maThanhVien)
        {
            if (maTask <= 0 || maThanhVien <= 0)
                return false;

            return dal.Delete(maTask, maThanhVien);
        }
    }
}