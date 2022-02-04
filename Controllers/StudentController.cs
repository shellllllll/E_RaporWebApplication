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

            var dataSISWA = _context.Tb_Siswa.ToList();
            return View(dataSISWA);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(StudentData datanya)
        {
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

                _context.Add(get);
                await _context.SaveChangesAsync();

                return RedirectToAction("TampilSiswa");
            }

            return View(datanya);
        }
    }
}
