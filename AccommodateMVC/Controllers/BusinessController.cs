using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccommodateMVC.Data;
using AccommodateMVC.Models;
using AccommodateMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccommodateMVC.Controllers
{
    public class BusinessController : Controller
    {
        private readonly AccessibleDbContext context;

        public BusinessController(AccessibleDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Business> businesses = context.Businesses.ToList();

            return View(businesses);
        }

        public IActionResult Add()
        {
            AddBusinessViewModel addBusinessViewModel = new AddBusinessViewModel();

            return View(addBusinessViewModel);
        }

        //add business and information associated with it
        [HttpPost]
        public IActionResult Add(AddBusinessViewModel addBusinessViewModel)
        {
            if (ModelState.IsValid)
            {
                Business newBusiness = new Business
                {
                    Name = addBusinessViewModel.Name,
                    Address = addBusinessViewModel.Address,
                    Type = addBusinessViewModel.Type
                };

                context.Businesses.Add(newBusiness);
                context.SaveChanges();

                return Redirect("/");
            }

            return View(addBusinessViewModel);
        }

        public IActionResult ViewBusiness(int id)
        {
            Business business = context.Businesses.Single(b => b.ID == id);

            List<BusinessAF> features = context
                .BusinessAFs
                .Include(feature => feature.AFeature)
                .Where(fb => fb.BusinessID == id)
                .ToList();

            ViewBusinessViewModel viewBusinessViewModel = new ViewBusinessViewModel
            {
                Business = business,
                Features = features
            };

            return View(viewBusinessViewModel);
        }

        [HttpGet("Business/AddFeature/{id:int}")]
        public IActionResult AddBusinessAccessibility(int id)
        {
            Business business = context.Businesses.Single(b => b.ID == id);

            AddBusinessAccessibilityViewModel addBusinessAccessibilityViewModel = new AddBusinessAccessibilityViewModel( business, context.AFeatures.ToList());

            return View(addBusinessAccessibilityViewModel);
        }

        [HttpPost]
        [Route("/Business/AddFeature/{id:int}")]
        public IActionResult AddBusinessAccessibility(AddBusinessAccessibilityViewModel addBusinessAccessibilityViewModel)
        {
            if (ModelState.IsValid)
            {
                IList<BusinessAF> existingFeatures = context.BusinessAFs
                    .Where(fb => fb.AFeatureID == addBusinessAccessibilityViewModel.AFeatureID)
                    .Where(fb => fb.BusinessID == addBusinessAccessibilityViewModel.BusinessID).ToList();
                if (existingFeatures.Count == 0)
                {
                    BusinessAF business = new BusinessAF
                    {
                        AFeatureID = addBusinessAccessibilityViewModel.AFeatureID,
                        BusinessID = addBusinessAccessibilityViewModel.BusinessID,
                    };

                    context.BusinessAFs.Add(business);
                    context.SaveChanges();

                    return Redirect("/Business/ViewBusiness/" + business.BusinessID);
                }
                return Redirect("/Business/ViewBusiness/" + addBusinessAccessibilityViewModel.BusinessID);
            }
            return View(addBusinessAccessibilityViewModel);
        }
    }
}
