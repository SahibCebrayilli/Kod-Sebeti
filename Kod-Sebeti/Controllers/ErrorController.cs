using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kod_Sebeti.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult NotFound(string aspxerrorpath)
        {
            if(!string.IsNullOrWhiteSpace(aspxerrorpath))
            {
                return RedirectToAction("NotFound");
            }
            return View();
        }

    }
}
