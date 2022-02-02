using E_RaporWebApplication.Data;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
