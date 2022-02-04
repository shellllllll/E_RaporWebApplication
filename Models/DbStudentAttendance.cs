using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class DbStudentAttendance
    {
        [Key]
        public int Nomor { get; set; }
        [Required]
        public string NIS { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Sakit { get; set; }
        [Required]
        public string Izin { get; set; }
        [Required]
        public string Tanpa_Keterangan { get; set; }
    }
}
