using E_RaporWebApplication.Data;
using E_RaporWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace E_RaporWebApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult TampilSiswa()
        {

            var dataSISWA = _context.Tb_Siswa.ToList();//sama saja dengan select * from tb_siswa
            return View(dataSISWA);

        }

        public IActionResult Create()//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(StudentData datanya)//mnerima halaman yg akan diisi(inputan/proses)
        {
            //proses masukan ke database
            if (ModelState.IsValid)
            {
                var get = new DbStudentData
                {
                    NIS = datanya.NIS,
                    NISN = datanya.NISN,
                    Nama = datanya.Nama,
                    Jenis_Kelamin = datanya.Jenis_Kelamin,
                    Alamat = datanya.Alamat
                };

                _context.Add(get);//mengganti dari insert into
                await _context.SaveChangesAsync();// menyimpan perubahan

                return RedirectToAction("TampilSiswa");
            }

            return View(datanya);
        }
    }
}
