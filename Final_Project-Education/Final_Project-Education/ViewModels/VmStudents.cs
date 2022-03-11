using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmStudents : VmLayout
    {
        public Banner Banner { get; set; }
        public List<Students> Students { get; set; }
        public VmSearch Search { get; set; }
        public List<Course> Courses { get; set; }


    }
}
