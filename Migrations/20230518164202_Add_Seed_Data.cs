using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThiThuSv_Hocphan.Migrations
{
    public partial class Add_Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaSv",
                table: "SinhViens",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "HocPhans",
                columns: new[] { "Id", "TenHocPhan" },
                values: new object[] { "1AB", "Lập trình .Net" });

            migrationBuilder.InsertData(
                table: "HocPhans",
                columns: new[] { "Id", "TenHocPhan" },
                values: new object[] { "831A", "Java" });

            migrationBuilder.InsertData(
                table: "HocPhans",
                columns: new[] { "Id", "TenHocPhan" },
                values: new object[] { "HAHA", "Đồ họa máy tính" });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "Id", "DiemBT", "DiemCK", "DiemGK", "GioiTinh", "HocPhanId", "LopSh", "TenSv" },
                values: new object[] { "102210000", 10.4, 5.5, 4.0, true, "831A", "21T_DT2", "Nguyễn Đình Lùi" });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "Id", "DiemBT", "DiemCK", "DiemGK", "GioiTinh", "HocPhanId", "LopSh", "TenSv" },
                values: new object[] { "102210024", 10.0, 9.0999999999999996, 8.0, true, "1AB", "21T_DT", "Nguyễn Đình Anh Tiến" });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "Id", "DiemBT", "DiemCK", "DiemGK", "GioiTinh", "HocPhanId", "LopSh", "TenSv" },
                values: new object[] { "102210025", 10.0, 9.9000000000000004, 8.1999999999999993, true, "1AB", "21T_DT", "Nguyễn Đình Tiễn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HocPhans",
                keyColumn: "Id",
                keyValue: "HAHA");

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: "102210000");

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: "102210024");

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: "102210025");

            migrationBuilder.DeleteData(
                table: "HocPhans",
                keyColumn: "Id",
                keyValue: "1AB");

            migrationBuilder.DeleteData(
                table: "HocPhans",
                keyColumn: "Id",
                keyValue: "831A");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SinhViens",
                newName: "MaSv");
        }
    }
}
