using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class DbAchievements
    {
        [Key]
        public string Nomor { get; set; }

        public string NIS { get; set; }

        public string Nama { get; set; }

        public string Jenis_Prestasi { get; set; }

        public string Deskripsi { get; set; }
    }
}
