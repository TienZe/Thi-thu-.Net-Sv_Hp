using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiThuSv_Hocphan.BLL;
using ThiThuSv_Hocphan.Models;

namespace ThiThuSv_Hocphan.Views
{
    public partial class DetailForm : Form
    {
        enum Type { Add = 1, Update }
        private Type type;
        public EventHandler ClickOk; // xử lý sự kiên ClickOk
        public DetailForm()
        {
            InitializeComponent();
            type = Type.Add;

            // Custom sự kiện cho 3 textbox điểm kiểm tra
            tbDiemBT.TextChanged += TinhDiemTongKet!;
            tbDiemGK.TextChanged += TinhDiemTongKet!;
            tbDiemCK.TextChanged += TinhDiemTongKet!;
        }
        public DetailForm(SinhVien model)
            : this()
        {
            type = Type.Update;

            // Điền model lên Form
            tbMSSV.Text = model.Id;
            tbTen.Text = model.TenSv;
            cbbLopSH.Text = model.LopSh;
            cbbHocPhan.Text = model.HocPhan.TenHocPhan;
            radioButtonMale.Checked = model.GioiTinh;
            radioButtonFemale.Checked = !radioButtonMale.Checked;

            tbDiemBT.Text = model.DiemBT.ToString();
            tbDiemGK.Text = model.DiemGK.ToString();
            tbDiemCK.Text = model.DiemCK.ToString();
        }

        private void TinhDiemTongKet(object sender, EventArgs e)
        {
            if (tbDiemBT.Text != "" && tbDiemGK.Text != "" && tbDiemCK.Text != "")
            {
                // Tính điểm tỗng kết
                double diemBT = Convert.ToDouble(tbDiemBT.Text);
                double diemGK = Convert.ToDouble(tbDiemGK.Text);
                double diemCK = Convert.ToDouble(tbDiemCK.Text);

                double diemTongKet = diemBT * 0.2 + diemGK * 0.2 + diemCK * 0.6;
                tbTongKet.Text = diemTongKet.ToString();
            }     
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            // Validation

            // Lấy dữ liệu từ Form về
            string mssv = tbMSSV.Text;
            string ten = tbTen.Text;
            string lopSh = cbbLopSH.Text;
            string tenHocPhan = cbbHocPhan.Text;
            bool gioiTinh = radioButtonMale.Checked;
            double diemBT = Convert.ToDouble(tbDiemBT.Text);
            double diemGK = Convert.ToDouble(tbDiemGK.Text);
            double diemCK = Convert.ToDouble(tbDiemCK.Text);

            // Tìm kiếm Học phần tương ứng dựa vào tên học phần
            HocPhan? hocPhan = HocPhan_BLL.Instance.GetHocPhanByName(tenHocPhan);

            // Nếu lớp học phần chưa tồn tại, cần thêm mới lớp học phần
            if (hocPhan == null)
            {
                hocPhan = new HocPhan()
                {
                    Id = Guid.NewGuid().ToString(),
                    TenHocPhan = tenHocPhan
                };
                HocPhan_BLL.Instance.AddHocPhan(hocPhan);
                MessageBox.Show("Thêm Học Phần mới thành công");
            }

            SinhVien sv = new SinhVien()
            {
                Id = mssv,
                TenSv = ten,
                LopSh = lopSh,
                GioiTinh = gioiTinh,
                DiemBT = diemBT,
                DiemGK = diemGK,
                DiemCK = diemCK,
                HocPhan = hocPhan
            };
            if (type == Type.Add)
            {
                SinhVien_BLL.Instance.AddSinhVien(sv);
            }
            else
            {
                // Update
                SinhVien_BLL.Instance.UpdateSinhVien(sv);
            }
            // Phát sinh sự kiện
            if (ClickOk != null) ClickOk.Invoke(this, EventArgs.Empty);

            MessageBox.Show(type.ToString() + " Sinh Viên thành công");
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            // Load cbbLopSH
            cbbLopSH.Items.AddRange(SinhVien_BLL.Instance.GetAllLopSh().ToArray());

            // Load cbbHocPhan
            cbbHocPhan.Items.AddRange(HocPhan_BLL.Instance.GetAllHocPhanName().ToArray());
        }
    }
}
