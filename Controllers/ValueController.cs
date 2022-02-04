using E_RaporWebApplication.Data;
using E_RaporWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Controllers
{
    public class ValueController : Controller
    {
        private readonly AppDbContext _context;
        public ValueController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult TampilValue()
        {
            return View();
        }
        public IActionResult IndexAchievement()
        {

            var dataPrestasi = _context.Tb_Prestasi.ToList();//sama saja dengan select * from tb_siswa
            return View(dataPrestasi);

        }
        public IActionResult IndexAttendance()
        {

            var dataKehadiran = _context.Tb_Kehadiran.ToList();//sama saja dengan select * from tb_siswa
            return View(dataKehadiran);

        }
        public IActionResult IndexAttitude()
        {

            var dataSikap = _context.Tb_Sikap.ToList();//sama saja dengan select * from tb_siswa
            return View(dataSikap);

        }
        public IActionResult IndexExtracurricular()
        {

            var dataEkstrakurikuler = _context.Tb_Ekstrakurikuler.ToList();//sama saja dengan select * from tb_siswa
            return View(dataEkstrakurikuler);

        }
        public IActionResult IndexSubject()
        {

            var dataMapel = _context.Tb_Mata_Pelajaran.ToList();//sama saja dengan select * from tb_siswa
            return View(dataMapel);

        }
        [HttpPost]
        public async Task<IActionResult> CreateAchievements(Achievements datanya)//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datanya);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexAchievement");
            }

            return View(datanya);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAttendance(StudentAttendance datanya)//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {

            if (ModelState.IsValid)
            {
                _context.Add(datanya);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexAttendance");
            }

            return View(datanya);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAttitude(AttitudeCompetence datanya)//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {

            if (ModelState.IsValid)
            {
                _context.Add(datanya);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexAttitude");
            }

            return View(datanya);
        }


        [HttpPost]
        public async Task<IActionResult> CreateExtracurricular(Extracurricular datanya)//UNTUK MENAMPILKAN HALAMAN YANG AKAN DIISI(kolom inputan)
        {

            if (ModelState.IsValid)
            {
                _context.Add(datanya);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexExtracurricular");
            }

            return View(datanya);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubject(Subjects datanya)//mnerima halaman yg akan diisi(inputan/proses)
        {
            //proses masukan ke database
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(datanya);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("IndexSubject");
                }

            }

            return View(datanya);
        }
    }
}
