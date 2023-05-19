using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThuSv_Hocphan.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<HocPhan> HocPhans { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=ThiThuSV_HocPhan;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<HocPhan>().HasData(
                new HocPhan() { Id = "1AB", TenHocPhan = "Lập trình .Net" },
                new HocPhan() { Id = "831A", TenHocPhan = "Java" },
                new HocPhan() { Id = "HAHA", TenHocPhan = "Đồ họa máy tính" }
                );
            modelBuilder.Entity<SinhVien>().HasData(
                new
                {
                    Id = "102210024",
                    TenSv = "Nguyễn Đình Anh Tiến",
                    LopSh = "21T_DT",
                    GioiTinh = true,
                    DiemBT = 10.0,
                    DiemGK = 8.0,
                    DiemCK = 9.1,
                    HocPhanId = "1AB"
                },
                new
                {
                    Id = "102210025",
                    TenSv = "Nguyễn Đình Tiễn",
                    LopSh = "21T_DT",
                    GioiTinh = true,
                    DiemBT = 10.0,
                    DiemGK = 8.2,
                    DiemCK = 9.9,
                    HocPhanId = "1AB"
                },
                new
                {
                    Id = "102210000",
                    TenSv = "Nguyễn Đình Lùi",
                    LopSh = "21T_DT2",
                    GioiTinh = true,
                    DiemBT = 10.4,
                    DiemGK = 4.0,
                    DiemCK = 5.5,
                    HocPhanId = "831A"
                }
                );
        }
    }
}
