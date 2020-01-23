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
            actionChoices.Add("public", "Check the Accessibility of a Public Entity");
            actionChoices.Add("event", "Search for Different Ability Friendly Events In My Area");

            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
    
