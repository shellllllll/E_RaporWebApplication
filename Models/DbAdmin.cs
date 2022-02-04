using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class DbAdmin
    {
        [Key]
        public string Nama_Pengguna { get; set; }
        [Required]
        public string Kata_Sandi { get; set; }
    }
}
