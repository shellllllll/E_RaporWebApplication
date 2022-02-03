using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class AttitudeCompetence
    {
        public string Nomor { get; set; }

        [Required]
        [DisplayName("NIS")]
        public string NIS { get; set; }

        [Required]
        [DisplayName("Nama Siswa")]
        public string Nama { get; set; }

        [Required]
        [DisplayName("Deskripsi Sikap")]
        public string Deskripsi_Sikap { get; set; }
    }
}
