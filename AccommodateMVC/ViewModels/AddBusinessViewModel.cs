using System;
using System.ComponentModel.DataAnnotations;

namespace AccommodateMVC.ViewModels
{
    public class AddBusinessViewModel
    {
        [Required]
        [Display(Name="Business Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Business Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name="Business Type")]
        public string Type { get; set; }

        public AddBusinessViewModel()
        {
        }
    }
}
