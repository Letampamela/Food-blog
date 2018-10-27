using BlogEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogEngine.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

           [HttpPost]
        public ActionResult Create(Blog b)
        {
               if(ModelState.IsValid)
               {
                   using (var ctx = new ApplicationDbContext())
                   {
                       ctx.blogs.Add(b);
                       ctx.SaveChanges();
                       return RedirectToAction("Index");
                   }
               }
            return View ();
        }
        public ActionResult Generic()
        {
            return View();
        }
    }
}