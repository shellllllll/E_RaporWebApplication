using E_RaporWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public virtual DbSet<DbAdmin> Tb_Admin { get; set; }
        public virtual DbSet<DbAchievements> Tb_Prestasi { get; set; }
        public virtual DbSet<DbAttitudeCompetence> Tb_Sikap { get; set; }
        public virtual DbSet<DbExtracurricular> Tb_Ekstrakurikuler { get; set; }
        public virtual DbSet<DbStudentAttendance> Tb_Kehadiran { get; set; }
        public virtual DbSet<DbStudentData> Tb_Siswa { get; set; }
        public virtual DbSet<DbSubjects> Tb_Mata_Pelajaran { get; set; }
        public virtual DbSet<DbTeacherData> Tb_Guru { get; set; }

    }
}
