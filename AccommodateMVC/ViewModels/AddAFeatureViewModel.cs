using System;
using AccommodateMVC.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccommodateMVC.ViewModels
{
    public class AddAFeatureViewModel
    {
        [Required(ErrorMessage = "Please enter a accessible feature")]
        [Display(Name = "Accessibility Feature")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please give a description of the feature")]
        public string Description { get; set; }

        

        public AddAFeatureViewModel()
        {
        }
    }
}
