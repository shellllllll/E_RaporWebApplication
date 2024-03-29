﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class TeacherData
    {
        public string Nomor { get; set; }
        
        [Required]
        [DisplayName("Nama")]
        public string Nama { get; set; }

        [Required]
        [DisplayName("NUPTK")]
        public string NUPTK { get; set; }

        [Required]
        [DisplayName("Mata Pelajaran")]
        public string Mata_Pelajaran { get; set; }
    }
}
