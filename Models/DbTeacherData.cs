using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class DbTeacherData
    {
        [Key]
        public int Nomor { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string NUPTK { get; set; }
        [Required]
        public string Mata_Pelajaran { get; set; }
    }
}
