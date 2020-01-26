using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccommodateMVC.Models
{
    public class Business
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }


        public IList<BusinessAF> BusinessAFs { get; set; }
       
    }
}
