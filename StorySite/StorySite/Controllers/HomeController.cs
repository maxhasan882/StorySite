using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorySite.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger("DemoLog");
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                log.Debug("Error in Index : " + e);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            try
            {
                return View();
            }
            catch (Exception e)
            {
                log.Debug("Error in About : " + e);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            try
            {
                return View();
            }
            catch (Exception e)
            {
                log.Debug("Error in Contact : " + e);
            }
        }
    }
}