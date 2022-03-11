using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmEvent : VmLayout
    {
        public List<Event> Events { get; set; }
        public List<Instructor> Instructors { get; set; }
        public Banner Banner { get; set; }
        public Event EventDetails { get; set; }
        public VmSearch Search { get; set; }
    }
}
