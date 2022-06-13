using AvatarAssignment_2MVC.DATA;
using AvatarAssignment_2MVC.Models;
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
            IEnumerable<Fighter> objList = _db.Fighters;//Coming from our database
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        //POST-Create- Inserting new expense data 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fighter obj)
        {
            if (ModelState.IsValid)
            {
                _db.Fighters.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Fighters.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //POST-Update updating the current data we have 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Fighter obj)
        {
            _db.Fighters.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Delete 
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Fighters.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        //Post Delete 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Fighters.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Fighters.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
