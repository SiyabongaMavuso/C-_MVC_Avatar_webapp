using AvatarAssignment_2MVC.DATA;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvatarAssignment_2MVC.Controllers
{
    public class FightersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FightersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
