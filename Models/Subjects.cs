﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class Subjects
    {
        public string Nomor { get; set; }

        [Required]
        [DisplayName("NIS")]
        public string NIS { get; set; }

        [Required]
        [DisplayName("Nama Siswa")]
        public string Nama { get; set; }

        [Required]
        [DisplayName("Pendidikan Agama")]
        public string Pendidikan_Agama { get; set; }

        [Required]
        [DisplayName("PPKN")]
        public string PPKN { get; set; }

        [Required]
        [DisplayName("Bahasa Indonesia")]
        public string Bahasa_Indonesia { get; set; }

        [Required]
        [DisplayName("Matematika")]
        public string Matematika { get; set; }

        [Required]
        [DisplayName("IPA")]
        public string IPA { get; set; }

        [Required]
        [DisplayName("IPS")]
        public string IPS { get; set; }

        [Required]
        [DisplayName("PJOK")]
        public string PJOK { get; set; }
    }
}
