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
using System.IO;


namespace MCproject.Controllers
{
    //  [Authorize(Roles = "Admin,Executive")]
    // [Route("Bike/Index")]
    public class bikeeController : Controller
    {
        private readonly Mcdbcontext _db;
    // private readonly HostingEnvironment _hostingEnvironment;
    

        [BindProperty]
        public BikeeViewModel MV { get; set; }


        public bikeeController(Mcdbcontext db ) //HostingEnvironment hostingEnvironment)
        {
            _db = db;
           // _hostingEnvironment = hostingEnvironment;
            MV = new BikeeViewModel()
            {
                Makes = _db.makes.ToList(),

                Models = _db.models.ToList(),
                // Model = new Models.models(Bikes
                bikeee = new Models.bikeee()
            };
        }

        public IActionResult Index()
        {
            var bikeee = _db.bikeees.Include(m => m.Make).Include(m => m.Model);
            return View(bikeee.ToList());
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
            _db.bikeees.Add(MV.bikeee);
            _db.SaveChanges();
            ///get bike id we have saved in database
            ///
          //  var bikeid = MV.bikeee.ID;
            //get wwwroothpath to save the file on server
         //  string WWWrootPath = _hostingEnvironment.ContentRootPath;
            //get the uploaded files
           // var files = HttpContext.Request.Form.Files;

            //get the reference of dbset for the bike we just have saved in database
         //   var SavedBike = _db.bikeees.Find(bikeid);
            //upload the files on server and save the image path of user have uploadede any file

            //if (files.Count!=0)
            //{
            //    var ImagePath = @"Images\Bike\";
            //    var Extensions = Path.GetExtension(files[0].FileName);
            //    var RelativeImagePath = ImagePath + bikeid + Extensions;
            //    var AbsImagePath = Path.Combine(WWWrootPath, RelativeImagePath);
            //    using(var fileStream=new FileStream(AbsImagePath,FileMode.Create))
            //    {
            //        files[0].CopyTo(fileStream);
            //    }
            //    SavedBike.Imagepath = RelativeImagePath;
            //    _db.SaveChanges();
            //}
       
            return RedirectToAction(nameof(Index));
        }
    }
}
