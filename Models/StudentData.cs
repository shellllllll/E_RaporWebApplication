﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class StudentData
    {
        [Required]
        [DisplayName("NIS")]
        public string NIS { get; set; }

        [Required]
        [DisplayName("NISN")]
        public string NISN { get; set; }

        [Required]
        [DisplayName("Nama Siswa")]
        public string Nama { get; set; }

        [Required]
        [DisplayName("Jenis Kelamin")]
        public string Jenis_Kelamin { get; set; }

        [Required]
        [DisplayName("Alamat")]
        public string Alamat { get; set; }
    }
}
