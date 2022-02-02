using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class Subjects
    {
        [Key]
        public int Nomor { get; set; }
        public string Nama { get; set; }
        public string NIS { get; set; }
        public string Pendidikan_Agama { get; set; }
        public string PPKN { get; set; }
        public string Bahasa_Indonesia { get; set; }
        public string Matematika { get; set; }
        public string IPA { get; set; }
        public string IPS { get; set; }
        public string Seni { get; set; }
        public string PJOK { get; set; }
        public string Informatika { get; set; }
    }
}
