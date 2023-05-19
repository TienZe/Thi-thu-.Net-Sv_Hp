﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThiThuSv_Hocphan.Models;

#nullable disable

namespace ThiThuSv_Hocphan.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230518164202_Add_Seed_Data")]
    partial class Add_Seed_Data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ThiThuSv_Hocphan.Models.HocPhan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenHocPhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HocPhans");

                    b.HasData(
                        new
                        {
                            Id = "1AB",
                            TenHocPhan = "Lập trình .Net"
                        },
                        new
                        {
                            Id = "831A",
                            TenHocPhan = "Java"
                        },
                        new
                        {
                            Id = "HAHA",
                            TenHocPhan = "Đồ họa máy tính"
                        });
                });

            modelBuilder.Entity("ThiThuSv_Hocphan.Models.SinhVien", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DiemBT")
                        .HasColumnType("float");

                    b.Property<double>("DiemCK")
                        .HasColumnType("float");

                    b.Property<double>("DiemGK")
                        .HasColumnType("float");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HocPhanId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LopSh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HocPhanId");

                    b.ToTable("SinhViens");

                    b.HasData(
                        new
                        {
                            Id = "102210024",
                            DiemBT = 10.0,
                            DiemCK = 9.0999999999999996,
                            DiemGK = 8.0,
                            GioiTinh = true,
                            HocPhanId = "1AB",
                            LopSh = "21T_DT",
                            TenSv = "Nguyễn Đình Anh Tiến"
                        },
                        new
                        {
                            Id = "102210025",
                            DiemBT = 10.0,
                            DiemCK = 9.9000000000000004,
                            DiemGK = 8.1999999999999993,
                            GioiTinh = true,
                            HocPhanId = "1AB",
                            LopSh = "21T_DT",
                            TenSv = "Nguyễn Đình Tiễn"
                        },
                        new
                        {
                            Id = "102210000",
                            DiemBT = 10.4,
                            DiemCK = 5.5,
                            DiemGK = 4.0,
                            GioiTinh = true,
                            HocPhanId = "831A",
                            LopSh = "21T_DT2",
                            TenSv = "Nguyễn Đình Lùi"
                        });
                });

            modelBuilder.Entity("ThiThuSv_Hocphan.Models.SinhVien", b =>
                {
                    b.HasOne("ThiThuSv_Hocphan.Models.HocPhan", "HocPhan")
                        .WithMany("SinhViens")
                        .HasForeignKey("HocPhanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocPhan");
                });

            modelBuilder.Entity("ThiThuSv_Hocphan.Models.HocPhan", b =>
                {
                    b.Navigation("SinhViens");
                });
#pragma warning restore 612, 618
        }
    }
}
