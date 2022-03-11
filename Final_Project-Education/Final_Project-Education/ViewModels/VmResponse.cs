using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmResponse
    {
        public string Success { get; set; }
        public string Error { get; set; }
        public string Changed { get; set; }
        public int StarsCount { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<InstructorRaiting> InstructorRaitingsCount { get; set; }


    }
}
