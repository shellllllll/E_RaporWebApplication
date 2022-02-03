using E_RaporWebApplication.Data;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create([Bind("Nama,NUPTK,MataPelajaran")] TeacherController teacherController)
        {
            if (ModelState.IsValid)
            {
                //teacherController.Id = teacherController.NUPTK.Ticks.ToString("x");
                _context.Add(teacherController);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(teacherController);
        }
    }
}
