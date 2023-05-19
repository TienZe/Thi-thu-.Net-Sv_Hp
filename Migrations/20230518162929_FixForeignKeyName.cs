using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThiThuSv_Hocphan.Migrations
{
    public partial class FixForeignKeyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinhViens_HocPhans_HocPhanMaHocPhan",
                table: "SinhViens");

            migrationBuilder.DropIndex(
                name: "IX_SinhViens_HocPhanMaHocPhan",
                table: "SinhViens");

            migrationBuilder.DropColumn(
                name: "HocPhanMaHocPhan",
                table: "SinhViens");

            migrationBuilder.RenameColumn(
                name: "MaHocPhan",
                table: "HocPhans",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "HocPhanId",
                table: "SinhViens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_HocPhanId",
                table: "SinhViens",
                column: "HocPhanId");

            migrationBuilder.AddForeignKey(
                name: "FK_SinhViens_HocPhans_HocPhanId",
                table: "SinhViens",
                column: "HocPhanId",
                principalTable: "HocPhans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinhViens_HocPhans_HocPhanId",
                table: "SinhViens");

            migrationBuilder.DropIndex(
                name: "IX_SinhViens_HocPhanId",
                table: "SinhViens");

            migrationBuilder.DropColumn(
                name: "HocPhanId",
                table: "SinhViens");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HocPhans",
                newName: "MaHocPhan");

            migrationBuilder.AddColumn<string>(
                name: "HocPhanMaHocPhan",
                table: "SinhViens",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_HocPhanMaHocPhan",
                table: "SinhViens",
                column: "HocPhanMaHocPhan");

            migrationBuilder.AddForeignKey(
                name: "FK_SinhViens_HocPhans_HocPhanMaHocPhan",
                table: "SinhViens",
                column: "HocPhanMaHocPhan",
                principalTable: "HocPhans",
                principalColumn: "MaHocPhan");
        }
    }
}
