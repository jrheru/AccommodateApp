using System;
using System.ComponentModel.DataAnnotations;

namespace AccommodateMVC.ViewModels
{
    public class AddBusinessViewModel
    {
        [Required(ErrorMessage = "Please enter a Business name")]
        [Display(Name="Business Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a address")]
        [Display(Name="Business Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "What is the business type?")]
        [Display(Name="Business Type")]
        public string Type { get; set; }

        public AddBusinessViewModel()
        {
        }
    }
}
