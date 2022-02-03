using Microsoft.EntityFrameworkCore.Migrations;

namespace E_RaporWebApplication.Migrations
{
    public partial class tb_guru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbAttitudeCompetence",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "text", nullable: true),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Deskripsi_Sikap = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbAttitudeCompetence", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Ekstrakurikuler",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "text", nullable: true),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Ekstrakurikuler = table.Column<string>(type: "text", nullable: true),
                    Grade = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Ekstrakurikuler", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Guru",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    NUPTK = table.Column<string>(type: "text", nullable: true),
                    Mata_Pelajaran = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Guru", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Mata_Pelajaran",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "text", nullable: true),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Pendidikan_Agama = table.Column<string>(type: "text", nullable: true),
                    PPKN = table.Column<string>(type: "text", nullable: true),
                    Bahasa_Indonesia = table.Column<string>(type: "text", nullable: true),
                    Matematika = table.Column<string>(type: "text", nullable: true),
                    IPA = table.Column<string>(type: "text", nullable: true),
                    IPS = table.Column<string>(type: "text", nullable: true),
                    PJOK = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Mata_Pelajaran", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Prestasi",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "text", nullable: true),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Jenis_Prestasi = table.Column<string>(type: "text", nullable: true),
                    Deskripsi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Prestasi", x => x.Nomor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Siswa",
                columns: table => new
                {
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    NISN = table.Column<string>(type: "text", nullable: true),
                    Nama = table.Column<string>(type: "text", nullable: true),
                    Jenis_Kelamin = table.Column<string>(type: "text", nullable: true),
                    Alamat = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Siswa", x => x.NIS);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbAttitudeCompetence");

            migrationBuilder.DropTable(
                name: "Tb_Ekstrakurikuler");

            migrationBuilder.DropTable(
                name: "Tb_Guru");

            migrationBuilder.DropTable(
                name: "Tb_Mata_Pelajaran");

            migrationBuilder.DropTable(
                name: "Tb_Prestasi");

            migrationBuilder.DropTable(
                name: "Tb_Siswa");
        }
    }
}
