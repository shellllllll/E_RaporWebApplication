using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class StudentData
    {
        [Key]
        public int Nomor { get; set; }
        public string Nama { get; set; }
        public string NIS { get; set; }
        public string NISN { get; set; }
        public string Tempat_Lahir { get; set; }
        public string Tanggal_Lahir { get; set; }
        public string Jenis_Kelamin { get; set; }
        public string Alamat { get; set; }
    }
}
