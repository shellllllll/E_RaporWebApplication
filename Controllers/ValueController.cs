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

            var dataPrestasi = _context.Tb_Prestasi.ToList();
            return View(dataPrestasi);

        }
        public IActionResult IndexAttendance()
        {

            var dataKehadiran = _context.Tb_Kehadiran.ToList();
            return View(dataKehadiran);

        }
        public IActionResult IndexAttitude()
        {

            var dataSikap = _context.Tb_Sikap.ToList();
            return View(dataSikap);

        }
        public IActionResult IndexExtracurricular()
        {

            var dataEkstrakurikuler = _context.Tb_Ekstrakurikuler.ToList();
            return View(dataEkstrakurikuler);

        }
        public IActionResult IndexSubject()
        {

            var dataMapel = _context.Tb_Mata_Pelajaran.ToList();
            return View(dataMapel);

        }



        public IActionResult CreateAchievements()
        {
            return View();
        }
        public IActionResult CreateAttendance()
        {
            return View();
        }
        public IActionResult CreateAttitude()
        {
            return View();
        }
        public IActionResult CreateExtracurricular()
        {
            return View();
        }
        public IActionResult CreateSubject()
        {
            return View();
        }












        [HttpPost]
        public async Task<IActionResult> CreateAchievements(DbAchievements datanya)
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
        public async Task<IActionResult> CreateAttendance(DbStudentAttendance datanya)
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
        public async Task<IActionResult> CreateAttitude(DbAttitudeCompetence datanya)
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
        public async Task<IActionResult> CreateExtracurricular(DbExtracurricular datanya)
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
        public async Task<IActionResult> CreateSubject(DbSubjects datanya)
        {

            if (ModelState.IsValid)
            {
                _context.Add(datanya);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexSubject");
            }

            return View(datanya);
        }
    }
}
