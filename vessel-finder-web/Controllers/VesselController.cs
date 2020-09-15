using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vessel_finder_web.Models;

namespace vessel_finder_web.Controllers
{
    public class VesselController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}