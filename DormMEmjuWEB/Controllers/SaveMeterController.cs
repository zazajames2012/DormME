using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormMEmjuWEB.Controllers
{

    [Authorize]
    public class SaveMeterController : Controller
    {
        // GET: SaveMeter
        
        public ActionResult Index()
        {
            return View();
        }
    }
}