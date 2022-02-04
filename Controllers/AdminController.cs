using E_RaporWebApplication.Data;
using E_RaporWebApplication.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_RaporWebApplication.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult LogIn()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LogIn(Admin namaInputan)
        {
            var cariAdmin = _context.Tb_Admin.Where(bebas =>
                  bebas.Nama_Pengguna == namaInputan.Nama_Pengguna &&
                  bebas.Kata_Sandi == namaInputan.Kata_Sandi
            ).FirstOrDefault();

            if (cariAdmin != null)
            {
                var cekpassword = _context.Tb_Admin.Where(bebas =>  //proses pencarian
                    bebas.Nama_Pengguna == namaInputan.Nama_Pengguna && 
                    bebas.Kata_Sandi == namaInputan.Kata_Sandi
                ).FirstOrDefault();

                if (cekpassword != null)
                {
                    //proses tampungan data 
                    var daftar = new List<Claim>
                    {
                        new Claim("NamaPengguna",cariAdmin.Nama_Pengguna)
                    };

                    //proses daftar auth
                    //await HttpContext.SignInAsync(
                    //     new ClaimsPrincipal(
                    //         new ClaimsIdentity(daftar, "Cookie", "Username", "Role")
                    //     )
                    //);

                    //if (cariAdmin.Roles.Id == "1")//admin
                    //{
                    //    return RedirectToAction(controllerName: "Home", actionName: "Index");
                    //}
                    //user
                    return RedirectToAction(controllerName: "Home", actionName: "Tampil");
                }

                ViewBag.pesan = "password salah";
                return View(namaInputan);
            }
            ViewBag.pesan = "Username salah";
            return View(namaInputan);
        }
    }
}
