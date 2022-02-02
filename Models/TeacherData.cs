using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Models
{
    public class TeacherData
    {
        [Key]
        public int ID { get; set; }
        public string Nama { get; set; }
        public string NUPTK { get; set; }
        public string Mata_Pelajaran { get; set; }
    }
}
