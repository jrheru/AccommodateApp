using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AccommodateMVC.Models;

namespace AccommodateMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("business", "Check for Accessibile Public Entities");
            actionChoices.Add("afeature", "List of Accessible Public Accommodations");

            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
    
