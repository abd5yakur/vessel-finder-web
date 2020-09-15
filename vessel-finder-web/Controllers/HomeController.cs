using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vessel_finder_web.Models;


namespace vessel_finder_web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Vessel vessel)
        {
            ViewData["IMO_No"] = vessel.IMO_No;
            TempData["IMO_No"] = vessel.IMO_No;
            TempData.Keep("IMO_No");


            if(vessel.IMO_No != null)
            {
                ViewBag.IMO = vessel.IMO_No;
                ViewBag.message = "IMO Number: " + vessel.IMO_No;
            }
            else
            {
                ViewBag.IMO = "Noob";
            }
            
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
