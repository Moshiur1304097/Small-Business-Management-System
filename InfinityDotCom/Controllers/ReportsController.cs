using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfinityDotCom.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult ReportOnSales()
        {
            return View();
        }

        public ActionResult ReportOnPurchase()
        {
            return View();
        }
    }
}