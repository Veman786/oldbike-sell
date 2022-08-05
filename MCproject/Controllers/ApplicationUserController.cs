using MCproject.MCdbcontext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCproject.Controllers
{
    public class ApplicationUserController : Controller
    {

        private readonly Mcdbcontext _db;

        public ApplicationUserController (Mcdbcontext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ApplicationUsers.ToList());
        }
        [HttpPost]
        public IActionResult Delete(string phonenumber2)
        {

            var ApplicationUser = _db.ApplicationUsers.Find(phonenumber2);
            if (ApplicationUser == null)
            {
                return NotFound();
            }
            _db.ApplicationUsers.Remove(ApplicationUser);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
     

    }

