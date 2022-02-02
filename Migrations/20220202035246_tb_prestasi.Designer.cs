﻿// <auto-generated />
using E_RaporWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_RaporWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220202035246_tb_prestasi")]
    partial class tb_prestasi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("E_RaporWebApplication.Models.Achievements", b =>
                {
                    b.Property<int>("Nomor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Deskripsi")
                        .HasColumnType("text");

                    b.Property<string>("Jenis_Prestasi")
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.HasKey("Nomor");

                    b.ToTable("Tb_Prestasi");
                });

            modelBuilder.Entity("E_RaporWebApplication.Models.AttitudeCompetence", b =>
                {
                    b.Property<int>("Nomor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Deskripsi_Sikap")
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.HasKey("Nomor");

                    b.ToTable("Tb_Sikap");
                });

            modelBuilder.Entity("E_RaporWebApplication.Models.Extracurricular", b =>
                {
                    b.Property<int>("Nomor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ekstrakurikuler")
                        .HasColumnType("text");

                    b.Property<string>("Grade")
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.HasKey("Nomor");

                    b.ToTable("Tb_Ekstrakurikuler");
                });

            modelBuilder.Entity("E_RaporWebApplication.Models.StudentAttendance", b =>
                {
                    b.Property<int>("Nomor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Izin")
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.Property<string>("Sakit")
                        .HasColumnType("text");

                    b.Property<string>("Tanpa_Keterangan")
                        .HasColumnType("text");

                    b.HasKey("Nomor");

                    b.ToTable("Tb_Kehadiran");
                });

            modelBuilder.Entity("E_RaporWebApplication.Models.StudentData", b =>
                {
                    b.Property<int>("Nomor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alamat")
                        .HasColumnType("text");

                    b.Property<string>("Jenis_Kelamin")
                        .HasColumnType("text");

                    b.Property<string>("NIS")
                        .HasColumnType("text");

                    b.Property<string>("NISN")
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.Property<string>("Tanggal_Lahir")
                        .HasColumnType("text");

                    b.Property<string>("Tempat_Lahir")
                        .HasColumnType("text");

                    b.HasKey("Nomor");

                    b.ToTable("Tb_Siswa");
                });

            modelBuilder.Entity("E_RaporWebApplication.Models.Subjects", b =>
                {
                    b.Property<int>("Nomor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bahasa_Indonesia")
                        .HasColumnType("text");

                    b.Property<string>("IPA")
                        .HasColumnType("text");

                    b.Property<string>("IPS")
                        .HasColumnType("text");

                    b.Property<string>("Informatika")
                        .HasColumnType("text");

                    b.Property<string>("Matematika")
                        .HasColumnType("text");

                    b.Property<string>("NIS")
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.Property<string>("PJOK")
                        .HasColumnType("text");

                    b.Property<string>("PPKN")
                        .HasColumnType("text");

                    b.Property<string>("Pendidikan_Agama")
                        .HasColumnType("text");

                    b.Property<string>("Seni")
                        .HasColumnType("text");

                    b.HasKey("Nomor");

                    b.ToTable("Tb_Mata_Pelajaran");
                });

            modelBuilder.Entity("E_RaporWebApplication.Models.TeacherData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Mata_Pelajaran")
                        .HasColumnType("text");

                    b.Property<string>("NUPTK")
                        .HasColumnType("text");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Tb_Guru");
                });
#pragma warning restore 612, 618
        }
    }
}