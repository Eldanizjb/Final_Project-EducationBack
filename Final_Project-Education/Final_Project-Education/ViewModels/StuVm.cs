using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class StuVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Graduate { get; set; }


        public DateTime CreatedDate { get; set; }
        public int CourseId { get; set; }
        public CursVM CCourse { get; set; }
    }
}
