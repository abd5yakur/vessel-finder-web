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

            TempData["IMO_No"] = null;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Vessel vessel)
        {
            ViewData["IMO_No"] = vessel.IMO_No;
            TempData["IMO_No"] = vessel.IMO_No;
            TempData.Keep("IMO_No");


            if (vessel.IMO_No != null)
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

        [HttpGet]
        public IActionResult Port()
        {

            TempData["port_name"] = null;

            return View();
        }

        [HttpPost]
        public IActionResult Port(Port port)
        {
            
            ViewData["port_name"] = port.name;
            TempData["port_name"] = port.name;
            TempData.Keep("port_name");

            ViewData["port_lat"] = port.latitude;
            TempData["port_lat"] = port.latitude;
            TempData.Keep("port_lat");

            ViewData["port_long"] = port.longitude;
            TempData["port_long"] = port.longitude;
            TempData.Keep("port_long");

            if (port.name != null)
            {
                ViewBag.port_name = port.name;
                ViewBag.message = "Port Name: " + port.name;
                ViewBag.latitude = port.latitude;
                ViewBag.longitude = port.longitude;


            }
            else
            {
                ViewBag.message = "Noob";
            }


            return View();
        }

        public IActionResult Klang()
        {
            return View();
        }

        public IActionResult Kuantan()
        {
            return View();
        }

        public IActionResult Kemaman()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddPort()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddPort(Port port)
        {

            ViewData["port_name"] = port.name;
            ViewData["port_lat"] = port.latitude;
            ViewData["port_long"] = port.longitude;

            TempData["port_name"] = port.name;
            TempData["port_lat"] = port.latitude;
            TempData["port_long"] = port.longitude;

            TempData.Keep("port_name");
            TempData.Keep("port_lat");
            TempData.Keep("port_long");



            return View();
        }


    }
}
