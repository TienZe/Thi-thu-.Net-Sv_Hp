using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThuSv_Hocphan.Models
{
    public class HocPhan
    {
        [Key]
        public string Id { get; set; }
        public string TenHocPhan { get; set; }
        public List<SinhVien> SinhViens { get; set; }
    }
}
