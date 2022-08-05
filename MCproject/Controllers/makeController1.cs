using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCproject.MCdbcontext;
using MCproject.Models;
using Microsoft.AspNetCore.Authorization;

namespace MCproject.Controllers
{
    [Authorize(Roles ="Admin,Executive")]
    public class makeController1 : Controller
    {
        
        private readonly Mcdbcontext _db;

        public makeController1(Mcdbcontext db)
        {
          _db = db;
        }
        //make/bikes
        public IActionResult bikes()
        {
            return View(_db.makes.ToList());
        }
        // HTTP GET
        public IActionResult Create()
        {
            return View();
       }
        [HttpPost]
        public IActionResult Create(make Make)

        {
            if(ModelState.IsValid)
            {
                _db.Add(Make);
                _db.SaveChanges();
                return RedirectToAction(nameof(bikes));
            }
            return View(Make);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var Make = _db.makes.Find(id);
            if(Make==null)
            {
                return NotFound();  
            }
            _db.makes.Remove(Make);
            _db.SaveChanges();
            return RedirectToAction(nameof(bikes));

        }
        public IActionResult Edit(int id)
        {
            var Make = _db.makes.Find(id);
            if (Make==null)
            {
                return NotFound();
            }
            return View(Make);
        }
        [HttpPost]
        public IActionResult Edit(make Make)

        {
            if (ModelState.IsValid)
            {
                _db.Update(Make);
                _db.SaveChanges();
                return RedirectToAction(nameof(bikes));
            }
            return View(Make);
        }
    }
}
