using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThuSv_Hocphan.Models;

namespace ThiThuSv_Hocphan.DAL
{
    public class SinhVienRepository : Repository<SinhVien>
    {
        public override void Add(SinhVien obj)
        {
            var context = new AppDbContext();
            // Tracking
            context.HocPhans.Attach(obj.HocPhan);
            // Added
            context.SinhViens.Add(obj);
            context.SaveChanges();
        }
        public IEnumerable<SinhVien> GetSinhVienIncludeHocPhan()
        {
            var context = new AppDbContext();
            return context.SinhViens.Include(sv => sv.HocPhan).ToList();
        }
        public IEnumerable<string> GetAllLopSh()
        {
            var context = new AppDbContext();
            return context.SinhViens.Select(sv => sv.LopSh).Distinct().ToList();
        }
        public SinhVien? GetSinhVienWithHocPhanById(string id)
        {
            var context = new AppDbContext();
            SinhVien? sv = context.SinhViens.Find(id);
            if (sv == null) return null;
            // Load Hoc Phan
            context.Entry(sv).Reference(sv => sv.HocPhan).Load();
            return sv;
        }
    }
}
