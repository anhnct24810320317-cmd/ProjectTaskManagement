using System.Data;
using ProjectTaskManagement.DTO;
using ProjectTaskManagement.DAL;

namespace ProjectTaskManagement.BUS
{
    public class DuAnBUS
    {
        DuAnDAL dal = new DuAnDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(DuAnDTO da)
        {
            if (string.IsNullOrWhiteSpace(da.TenDuAn))
                return false;

            return dal.Insert(da);
        }

        public bool Update(DuAnDTO da)
        {
            if (da.MaDuAn <= 0 ||
                string.IsNullOrWhiteSpace(da.TenDuAn))
                return false;

            return dal.Update(da);
        }

        public bool Delete(int maDuAn)
        {
            if (maDuAn <= 0)
                return false;

            return dal.Delete(maDuAn);
        }

        public DataTable Search(string tenDuAn)
        {
            return dal.Search(tenDuAn);
        }
    }
}