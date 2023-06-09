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
    [Migration("20230518162634_Initial")]
    partial class Initial
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
                    b.Property<string>("MaHocPhan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenHocPhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHocPhan");

                    b.ToTable("HocPhans");
                });

            modelBuilder.Entity("ThiThuSv_Hocphan.Models.SinhVien", b =>
                {
                    b.Property<string>("MaSv")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DiemBT")
                        .HasColumnType("float");

                    b.Property<double>("DiemCK")
                        .HasColumnType("float");

                    b.Property<double>("DiemGK")
                        .HasColumnType("float");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HocPhanMaHocPhan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LopSh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSv");

                    b.HasIndex("HocPhanMaHocPhan");

                    b.ToTable("SinhViens");
                });

            modelBuilder.Entity("ThiThuSv_Hocphan.Models.SinhVien", b =>
                {
                    b.HasOne("ThiThuSv_Hocphan.Models.HocPhan", "HocPhan")
                        .WithMany("SinhViens")
                        .HasForeignKey("HocPhanMaHocPhan");

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
