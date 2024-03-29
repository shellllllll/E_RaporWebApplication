﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class StudentAttendance
    {
        public string Nomor { get; set; }

        [Required]
        [DisplayName("NIS")]
        public string NIS { get; set; }

        [Required]
        [DisplayName("Nama Siswa")]
        public string Nama { get; set; }

        [Required]
        [DisplayName("Sakit")]
        public string Sakit { get; set; }

        [Required]
        [DisplayName("Izin")]
        public string Izin { get; set; }

        [Required]
        [DisplayName("Tanpa Keterangan")]
        public string Tanpa_Keterangan { get; set; }
    }
}
