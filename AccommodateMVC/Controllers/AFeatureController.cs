using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccommodateMVC.Models;
using AccommodateMVC.ViewModels;
using Microsoft.EntityFrameworkCore;
using AccommodateMVC.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccommodateMVC.Controllers
{
    public class AFeatureController : Controller
    {
        private AccessibleDbContext context;

        public AFeatureController(AccessibleDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<AFeature> features = context.AFeatures.ToList();

            return View(features);
        }

        public IActionResult Add()
        {
            AddAFeatureViewModel addAFeatureViewModel = new AddAFeatureViewModel();

            return View(addAFeatureViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddAFeatureViewModel addAFeatureViewModel)
        {
            if (ModelState.IsValid)
            {
                AFeature newAFeature = new AFeature
                {
                    Name = addAFeatureViewModel.Name,
                    Description = addAFeatureViewModel.Description
                };

                context.AFeatures.Add(newAFeature);
                context.SaveChanges();

                return Redirect("/");
            }
            return View(addAFeatureViewModel);
        }
    }
}
