using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThiThuSv_Hocphan.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HocPhans",
                columns: table => new
                {
                    MaHocPhan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHocPhan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocPhans", x => x.MaHocPhan);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LopSh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    DiemBT = table.Column<double>(type: "float", nullable: false),
                    DiemGK = table.Column<double>(type: "float", nullable: false),
                    DiemCK = table.Column<double>(type: "float", nullable: false),
                    HocPhanMaHocPhan = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSv);
                    table.ForeignKey(
                        name: "FK_SinhViens_HocPhans_HocPhanMaHocPhan",
                        column: x => x.HocPhanMaHocPhan,
                        principalTable: "HocPhans",
                        principalColumn: "MaHocPhan");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_HocPhanMaHocPhan",
                table: "SinhViens",
                column: "HocPhanMaHocPhan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "HocPhans");
        }
    }
}
