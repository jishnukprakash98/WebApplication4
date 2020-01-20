using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        static List<Library> Books = new List<Library>();

      
        public ActionResult Index()
        {
            return View();
        }
         [HttpPost]
        public ActionResult Index(Users user)
        {
             string username = "Admin123";
             string password = "@Admin123";

            if(user.Username==username && user.Password == password)
            {
                ViewBag.DisplayLinkStatus = "visible";
                return RedirectToAction("AddBooks","Home");
            
            }
            else
                return View("Error");
        }


        public ActionResult AddBooks()
        {
            ViewBag.Message = "Add Books";
            return View();
        }

        [HttpPost]
        public ActionResult AddBooks(Library lib)
        {
            
            Books.Add(lib);
            //ViewBag.bookId = lib.bookId;
            //ViewBag.bookName = lib.bookName;
            return View();
        }

        public ActionResult showBooks()
        {
            ViewBag.Message = "Available Books";
           
            return View(Books);
        }

        public ActionResult Bye()
        {
            ViewBag.Message = "Thank you visit again";

            return View();
        }
  

      
    }
}