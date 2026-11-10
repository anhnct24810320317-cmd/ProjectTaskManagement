using System.Data;
using ProjectTaskManagement.DTO;
using ProjectTaskManagement.DAL;

namespace ProjectTaskManagement.BUS
{
    public class CongViecBUS
    {
        CongViecDAL dal = new CongViecDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(CongViecDTO cv)
        {
            if (cv.MaDuAn <= 0 ||
                string.IsNullOrWhiteSpace(cv.TenTask))
                return false;

            return dal.Insert(cv);
        }

        public bool Update(CongViecDTO cv)
        {
            if (cv.MaTask <= 0 ||
                cv.MaDuAn <= 0 ||
                string.IsNullOrWhiteSpace(cv.TenTask))
                return false;

            return dal.Update(cv);
        }

        public bool Delete(int maTask)
        {
            if (maTask <= 0)
                return false;

            return dal.Delete(maTask);
        }

        public DataTable Search(string tenTask)
        {
            return dal.Search(tenTask);
        }
    }
}