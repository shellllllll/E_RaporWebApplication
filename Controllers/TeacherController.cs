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

            var dataGuru= _context.Tb_Guru.ToList();
            return View(dataGuru);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TeacherData datanya)
        {
            if (ModelState.IsValid)
            {
                var get = new DbTeacherData
                {
                    NUPTK=datanya.NUPTK,
                    Nama = datanya.Nama,
                    Mata_Pelajaran=datanya.Mata_Pelajaran
                };

                _context.Add(get);
                await _context.SaveChangesAsync();

                return RedirectToAction("TampilTeacher");
            }

            return View(datanya);
        }
    }
}
