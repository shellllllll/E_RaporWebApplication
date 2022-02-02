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
        public virtual DbSet<Achievements> Tb_Prestasi { get; set; }
        public virtual DbSet<AttitudeCompetence> Tb_Sikap { get; set; }
        public virtual DbSet<Extracurricular> Tb_Ekstrakurikuler { get; set; }
        public virtual DbSet<StudentAttendance> Tb_Kehadiran { get; set; }
        public virtual DbSet<StudentData> Tb_Siswa { get; set; }
        public virtual DbSet<Subjects> Tb_Mata_Pelajaran { get; set; }
        public virtual DbSet<TeacherData> Tb_Guru { get; set; }

    }
}
