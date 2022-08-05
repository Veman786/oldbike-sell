using MCproject.MCdbcontext;
using MCproject.Models;
using MCproject.Models.viewmodel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCproject.Controllers
{
  //  [Authorize(Roles = "Admin,Executive")]
    public class ModellController1 : Controller
    {
        private readonly Mcdbcontext _db;
       
        [BindProperty]
        public modelview MV { get; set; }


        public ModellController1(Mcdbcontext db)
        {
            _db = db;
            MV = new modelview()
            {
                makes = _db.makes.ToList(),
                Model = new Models.models()
            };
        }
        public IActionResult Index()
        {
            var model = _db.models.Include(m => m.make);
            return View(model.ToList());
        }
        public IActionResult create()
        {
            return View(MV);
        }
        [HttpPost]
        public IActionResult Create()
        {
            if (!ModelState.IsValid)
            {
                return View(MV);
            }
            _db.models.Add(MV.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            
           MV.Model = _db.models.Include(m => m.make).SingleOrDefault(m => m.id == id);
            if (MV.Model == null)
            {
                return NotFound();
            }
            return View(MV);
        }
        [HttpPost, ActionName("Edit")]
        public IActionResult EditPost(models model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _db.models.Update(model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            models model = _db.models.Find(id);
            if(model==null)
            {
                return NotFound();
            }
            _db.models.Remove(model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [AllowAnonymous]
        [HttpGet("api/models")]
        public IEnumerable<models>Models()
        {
            return _db.models.ToList();
        }
           
    }
}