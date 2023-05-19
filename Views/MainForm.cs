using System.Collections.Generic;
using System.Security.Policy;
using ThiThuSv_Hocphan.BLL;
using ThiThuSv_Hocphan.DTO;
using ThiThuSv_Hocphan.Models;

namespace ThiThuSv_Hocphan.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadDtgv(string tenHocPhan = "All")
        {
            if (tenHocPhan == "All")
            {
                dataGridView1.DataSource = SinhVien_BLL.Instance
                    .GetAllSinhVienWithHocPhan().ToList();
            }
            else
            {
                dataGridView1.DataSource = SinhVien_BLL.Instance
                    .GetSinhVienByHocPhan(tenHocPhan).ToList();
            }
        }
        private void LoadCbbHocPhan()
        {
            var items = HocPhan_BLL.Instance.GetAllHocPhanName();
            cbbHocPhan.Items.Clear();
            cbbHocPhan.Items.Add("All");
            cbbHocPhan.Items.AddRange(items.ToArray());
            cbbHocPhan.Text = "All";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load các học phần lên cbbHocPhan
            LoadCbbHocPhan();

            // Hiển thị dữ liệu lên datagridview
            LoadDtgv();
        }
        public void btAdd_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            // Đăng kí xử lý sự kiện
            detailForm.ClickOk += (sender, eventArgs) => LoadCbbHocPhan();
            detailForm.ClickOk += (sender, eventArsg) => LoadDtgv();
            detailForm.Show();
        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load lại datagridview theo Học Phần tương ứng
            string tenHocPhan = cbbHocPhan.Text;
            LoadDtgv(tenHocPhan);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string txt = tbSearch.Text;
            if (txt != string.Empty)
            {
                // Tìm kiếm theo tên sinh viên và mã sinh viên
                // Dữ liệu đang lưu ở datagridview (in-memory) là dữ liệu đã được lọc Học Phần
                // Ta chỉ cần lọc thêm theo tên sinh viên và mã sinh viên như yêu cầu
                IEnumerable<ViewModel>? viewModels = dataGridView1.DataSource as IEnumerable<ViewModel>;
                dataGridView1.DataSource = viewModels
                    ?.Where(vm => vm.Mssv.Contains(txt) || vm.TenSv.Contains(txt)).ToList();
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (cbbSortType.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn kiểu sắp xếp");
                return;
            }
            string? sortType = cbbSortType.SelectedItem as string;

            // Sort dữ liệu đang hiển thị ở datagridview (in-memory)
            IEnumerable<ViewModel>? viewModels = dataGridView1.DataSource as IEnumerable<ViewModel>;
            if (sortType == "Mssv")
            {
                dataGridView1.DataSource = viewModels?.OrderBy(vm => vm.Mssv).ToList();
            }
            else
            {
                dataGridView1.DataSource = viewModels?.OrderBy(vm => vm.TongKet).ToList();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn các dòng muốn xóa");
                return;
            }
            List<string> deleteIds = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells["Mssv"].Value.ToString()!;
                deleteIds.Add(id);
            }
            SinhVien_BLL.Instance.DeleteSinhVien(deleteIds);
            LoadDtgv(cbbHocPhan.Text);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0 || selectedRows.Count > 1)
            {
                MessageBox.Show("Chọn một dòng để update");
                return;
            }

            string id = selectedRows[0].Cells["Mssv"].Value.ToString()!;
            SinhVien? sv = SinhVien_BLL.Instance.GetSinhVienById(id);
            if (sv != null)
            {
                DetailForm detailForm = new DetailForm(sv);
                // Đăng kí xử lý sự kiện
                detailForm.ClickOk += (sender, eventArgs) => LoadCbbHocPhan();
                detailForm.ClickOk += (sender, eventArsg) => LoadDtgv();
                detailForm.Show();
            }
        }
    }
}