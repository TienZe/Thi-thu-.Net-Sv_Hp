using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThuSv_Hocphan.Models
{
    public class SinhVien
    {
        [Key]
        public string Id { get; set; }
        public string TenSv { get; set; }
        public string LopSh { get; set; }
        public bool GioiTinh { get; set; }
        public double DiemBT { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public HocPhan HocPhan { get; set; }
    }
}
