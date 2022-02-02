using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace E_RaporWebApplication.Migrations
{
    public partial class tb_prestasi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Ekstrakurikuler",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Ekstrakurikuler = table.Column<string>(type: "text", nullable: true),
                    Grade = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Ekstrakurikuler", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Kehadiran",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Sakit = table.Column<string>(type: "text", nullable: true),
                    Izin = table.Column<string>(type: "text", nullable: true),
                    Tanpa_Keterangan = table.Column<string>(type: "text", nullable: true)
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
                    Nama = table.Column<string>(type: "text", nullable: true),
                    NIS = table.Column<string>(type: "text", nullable: true),
                    Pendidikan_Agama = table.Column<string>(type: "text", nullable: true),
                    PPKN = table.Column<string>(type: "text", nullable: true),
                    Bahasa_Indonesia = table.Column<string>(type: "text", nullable: true),
                    Matematika = table.Column<string>(type: "text", nullable: true),
                    IPA = table.Column<string>(type: "text", nullable: true),
                    IPS = table.Column<string>(type: "text", nullable: true),
                    Seni = table.Column<string>(type: "text", nullable: true),
                    PJOK = table.Column<string>(type: "text", nullable: true),
                    Informatika = table.Column<string>(type: "text", nullable: true)
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
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Jenis_Prestasi = table.Column<string>(type: "text", nullable: true),
                    Deskripsi = table.Column<string>(type: "text", nullable: true)
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
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Deskripsi_Sikap = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Sikap", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Siswa",
                columns: table => new
                {
                    Nomor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    NIS = table.Column<string>(type: "text", nullable: true),
                    NISN = table.Column<string>(type: "text", nullable: true),
                    Tempat_Lahir = table.Column<string>(type: "text", nullable: true),
                    Tanggal_Lahir = table.Column<string>(type: "text", nullable: true),
                    Jenis_Kelamin = table.Column<string>(type: "text", nullable: true),
                    Alamat = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Siswa", x => x.Nomor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Ekstrakurikuler");

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
