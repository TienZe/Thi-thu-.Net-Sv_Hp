using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThuSv_Hocphan.DAL;
using ThiThuSv_Hocphan.Models;

namespace ThiThuSv_Hocphan.BLL
{
    public class HocPhan_BLL
    {
        private static HocPhan_BLL instance;
        public static HocPhan_BLL Instance
        {
            get
            {
                if (instance == null) 
                    instance = new HocPhan_BLL();
                return instance;
            }
        }

        private readonly HocPhanRepository repo;
        private HocPhan_BLL()
        {
            repo = new HocPhanRepository();
        }
        public void AddHocPhan(HocPhan hocPhan)
        {
            repo.Add(hocPhan);
        }
        public HocPhan? GetHocPhanByName(string name)
        {
            return repo.GetByName(name);
        }
        public IEnumerable<string> GetAllHocPhanName()
        {
            return repo.GetAll().Select(hp => hp.TenHocPhan);
        }
    }
}
