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
    // [Route("Bike/Index")]
    public class BikeController : Controller
    {
        private readonly Mcdbcontext _db;

        [BindProperty]
        public Bikeviewmodel MV { get; set; }


        public BikeController(Mcdbcontext db)
        {
            _db = db;
            MV = new Bikeviewmodel()
            {
                Makes = _db.makes.ToList(),

                Models = _db.models.ToList(),
                // Model = new Models.models()
                Bike = new Models.Bike()
            };
        }

        public IActionResult Index()
        {
            var bikes = _db.bikes.Include(m => m.make).Include(m => m.models);
            return View(bikes.ToList());
        }
        public IActionResult create()
        {
            return View(MV);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            if (!ModelState.IsValid)
            {
                MV.Makes = _db.makes.ToList();
                MV.Models = _db.models.ToList();
                return View(MV);
            }
            _db.bikes.Add(MV.Bike);
            _db.SaveChanges();
          //  var BikeID = MV.Bike.Id;
            return RedirectToAction(nameof(Index));
        }
        //    public IActionResult Edit(int id)
        //    {

        //        MV.Bike = _db.Bikes.Include(m => m.make).SingleOrDefault(m => m.Id == id);
        //        if (MV.Bike == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(MV);
        //    }
        //    [HttpPost, ActionName("Edit")]
        //    public IActionResult EditPost(models model)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View(model);
        //        }
        //        _db.models.Update(model);
        //        _db.SaveChanges();
        //        return RedirectToAction(nameof(Index));

        //    }
        //    [HttpPost]
        //    public IActionResult Delete(int id)
        //    {
        //        models model = _db.models.Find(id);
        //        if (model == null)
        //        {
        //            return NotFound();
        //        }
        //        _db.models.Remove(model);
        //        _db.SaveChanges();
        //        return RedirectToAction(nameof(Index));
        //    }

        //}
    }
}
