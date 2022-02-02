﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class StudentAttendance
    {
        [Key]
        public int Nomor { get; set; }
        public string Nama { get; set; }
        public string Sakit { get; set; }
        public string Izin { get; set; }
        public string Tanpa_Keterangan { get; set; }
    }
}