using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace E_RaporWebApplication.Migrations
{
    public partial class tb_admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Admin",
                columns: table => new
                {
                    Nama_Pengguna = table.Column<string>(type: "varchar(767)", nullable: false),
                    Kata_Sandi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Admin", x => x.Nama_Pengguna);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Ekstrakurikuler",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NIS = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Ekstrakurikuler = table.Column<string>(type: "text", nullable: false),
                    Grade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Ekstrakurikuler", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Guru",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    NUPTK = table.Column<string>(type: "text", nullable: false),
                    Mata_Pelajaran = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Guru", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Kehadiran",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NIS = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Sakit = table.Column<string>(type: "text", nullable: false),
                    Izin = table.Column<string>(type: "text", nullable: false),
                    Tanpa_Keterangan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kehadiran", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Mata_Pelajaran",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NIS = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Pendidikan_Agama = table.Column<string>(type: "text", nullable: false),
                    PPKN = table.Column<string>(type: "text", nullable: false),
                    Bahasa_Indonesia = table.Column<string>(type: "text", nullable: false),
                    Matematika = table.Column<string>(type: "text", nullable: false),
                    IPA = table.Column<string>(type: "text", nullable: false),
                    IPS = table.Column<string>(type: "text", nullable: false),
                    PJOK = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Mata_Pelajaran", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Prestasi",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NIS = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Jenis_Prestasi = table.Column<string>(type: "text", nullable: false),
                    Deskripsi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Prestasi", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Sikap",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NIS = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Deskripsi_Sikap = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Sikap", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Siswa",
                columns: table => new
                {
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    NISN = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Jenis_Kelamin = table.Column<string>(type: "text", nullable: false),
                    Alamat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Siswa", x => x.NIS);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Admin");

            migrationBuilder.DropTable(
                name: "Tb_Ekstrakurikuler");

            migrationBuilder.DropTable(
                name: "Tb_Guru");

            migrationBuilder.DropTable(
                name: "Tb_Kehadiran");

            migrationBuilder.DropTable(
                name: "Tb_Mata_Pelajaran");

            migrationBuilder.DropTable(
                name: "Tb_Prestasi");

            migrationBuilder.DropTable(
                name: "Tb_Sikap");

            migrationBuilder.DropTable(
                name: "Tb_Siswa");
        }
    }
}
