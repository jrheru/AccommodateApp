using System;

namespace AccommodateMVC.Models
{
    public class BusinessAF
    {
        public int BusinessID { get; set; }
        public Business Business { get; set; }

        public int AFeatureID { get; set; }
        public AFeature AFeature { get; set; }

        public BusinessAF()
        {
        }
    }
}
