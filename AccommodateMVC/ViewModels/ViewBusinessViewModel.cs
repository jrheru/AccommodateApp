using System;
using System.Collections.Generic;
using AccommodateMVC.Models;

namespace AccommodateMVC.ViewModels
{
    public class ViewBusinessViewModel
    {
        public Business Business { get; set; }

        public IList<BusinessAF> Features { get; set; }

        public ViewBusinessViewModel()
        {
        }
    }
}
