using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlogA.Controllers
{
    public class AuthController : Controller
    {
        
        public ActionResult login()
        {
            return Content("Auth controller login action");
        }
    }
}