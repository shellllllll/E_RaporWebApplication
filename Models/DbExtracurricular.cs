using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class DbExtracurricular
    {
        [Key]
        public string Nomor { get; set; }

        public string NIS { get; set; }

        public string Nama { get; set; }

        public string Ekstrakurikuler { get; set; }

        public string Grade { get; set; }
    }
}
