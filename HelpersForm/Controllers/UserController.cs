using HelpersForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpersForm.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("VerUser", user);
            }
            else return View();
    
        
        }
        public ActionResult VerUser(Usuario x)
        {
            return View(x);
        }

    }
}