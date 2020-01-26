using System.Collections.Generic;

namespace AccommodateMVC.Models
{
    public class AFeature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<BusinessAF> BusinessAFs { get; set; }

    }
}
