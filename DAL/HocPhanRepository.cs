using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThuSv_Hocphan.Models;

namespace ThiThuSv_Hocphan.DAL
{
    public class HocPhanRepository : Repository<HocPhan>
    {
        public HocPhan? GetByName(string name)
        {
            var context = new AppDbContext();
            return context.HocPhans.Where(hp => hp.TenHocPhan == name).FirstOrDefault();
        }
    }
}
