using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThuSv_Hocphan.DTO;

namespace ThiThuSv_Hocphan.Models
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<ViewModel> ToViewModel(this IEnumerable<SinhVien> sinhViens)
        {
            return sinhViens.Select(sv => new ViewModel
            {
                Mssv = sv.Id,
                TenSv = sv.TenSv,
                LopSh = sv.LopSh,
                GioiTinh = sv.GioiTinh,
                DiemBT = sv.DiemBT,
                DiemGK = sv.DiemGK,
                DiemCK = sv.DiemCK,
                TongKet = sv.DiemBT * 0.2 + sv.DiemGK * 0.2 + sv.DiemCK * 0.6,
                TenHocPhan = sv.HocPhan.TenHocPhan
            });
        }
    }
}
