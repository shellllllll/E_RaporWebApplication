using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class Achievements
    {
        [Key]
        public int Nomor { get; set; }
        public string Nama { get; set; }
        public string Jenis_Prestasi { get; set; }
        public string Deskripsi { get; set; }
    }
}
