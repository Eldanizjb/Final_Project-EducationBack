using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmPricing : VmLayout
    {
        public Banner Banner { get; set; }
        public List<Pricing> Pricings { get; set; }
        public List<Feedback> Feedbacks { get; set; }

    }
}
