using System;
using AccommodateMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccommodateMVC.ViewModels
{
    public class AddBusinessAccessibilityViewModel
    {
        [Display(Name="Accessibility")]
        public int AFeatureID { get; set; }
        public int BusinessID { get; set; }

        public Business Business { get; set; }
        public List<SelectListItem> Features { get; set; }

        public AddBusinessAccessibilityViewModel()
        { }

        public AddBusinessAccessibilityViewModel(Business business, IEnumerable<AFeature> features)
        {
            Business = business;
            Features = new List<SelectListItem>();

            foreach(var feature in features)
            {
                Features.Add(new SelectListItem
                {
                    Value = feature.ID.ToString(),
                    Text = feature.Name
                });    
            }
        }
    }
}
