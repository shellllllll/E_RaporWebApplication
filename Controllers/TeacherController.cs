using E_RaporWebApplication.Data;
using E_RaporWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult TampilTeacher()
        {

            var dataGuru= _context.Tb_Guru.ToList();//sama saja dengan select * from tb_siswa
            return View(dataGuru);

        }

        public IActionResult Create()//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TeacherData datanya)//mnerima halaman yg akan diisi(inputan/proses)
        {
            //proses masukan ke database
            if (ModelState.IsValid)
            {
                var get = new DbTeacherData
                {
                    NUPTK=datanya.NUPTK,
                    Nama = datanya.Nama,
                    Mata_Pelajaran=datanya.Mata_Pelajaran
                };

                _context.Add(get);//mengganti dari insert into
                await _context.SaveChangesAsync();// menyimpan perubahan

                return RedirectToAction("TampilTeacher");
            }

            return View(datanya);
        }
    }
}
