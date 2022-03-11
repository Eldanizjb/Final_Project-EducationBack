using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmFaq : VmLayout
    {
        public Banner Banner { get; set; }
        public List<FAQ> FAQs { get; set; }

    }
}
