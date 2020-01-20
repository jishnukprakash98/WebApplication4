using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFoundErrorHandler()
        {
            return View();
        }
        [HandleError]
        public ActionResult AnyError()
        {
            throw new Exception("Oh Oh an error occured");
        }
    }
}