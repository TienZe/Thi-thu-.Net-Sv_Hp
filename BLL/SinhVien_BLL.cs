using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThuSv_Hocphan.DAL;
using ThiThuSv_Hocphan.DTO;
using ThiThuSv_Hocphan.Models;

namespace ThiThuSv_Hocphan.BLL
{
    public class SinhVien_BLL
    {
        private static SinhVien_BLL instance;
        public static SinhVien_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SinhVien_BLL();
                return instance;
            }
        }

        private readonly SinhVienRepository repo;
        public SinhVien_BLL()
        {
            repo = new SinhVienRepository();
        }
        public void AddSinhVien(SinhVien sinhVien)
        {
            repo.Add(sinhVien);
        }
        public IEnumerable<ViewModel> GetAllSinhVienWithHocPhan()
        {
            return repo.GetSinhVienIncludeHocPhan().ToViewModel();
        }
        public IEnumerable<ViewModel> GetSinhVienByHocPhan(string tenHocPhan)
        {
            return repo.GetSinhVienIncludeHocPhan()
                .Where(sv => sv.HocPhan.TenHocPhan == tenHocPhan)
                .ToViewModel();
        }
        public void DeleteSinhVien(IEnumerable<string> ids)
        {
            foreach (string id in ids)
            {
                repo.Delete(id);
            }
        }
        public IEnumerable<string> GetAllLopSh()
        {
            return repo.GetAllLopSh();
        }
        public SinhVien? GetSinhVienById(string id)
        {
            return repo.GetSinhVienWithHocPhanById(id);
        }
        public void UpdateSinhVien(SinhVien sv)
        {
            repo.Update(sv);
        }
    }
}
