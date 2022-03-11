using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmCourse : VmLayout
    {
        public Banner Banner { get; set; }
        public List<Course> Courses { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<InstructorSocial> InstructorSocials { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }
        public List<CourseLevel> CourseLevels { get; set; }
        public List<Students> Students { get; set; }
        public List<Advice> Advices { get; set; }
        public Instructor Instructor { get; set; }
        public List<InstructorRaiting> InstructorRaiting { get; set; }

        public Course CourseDetails { get; set; }

        public VmSearch Search { get; set; }
        public Commenter Commenter { get; set; }

    }
}
