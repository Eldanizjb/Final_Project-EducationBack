using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmInstructor : VmLayout
    {
        public Banner Banner { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<InstructorSocial> InstructorSocials { get; set; }
        public List<Course> Courses { get; set; }
        public Instructor InstructorDetails { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }
        public List<Students> Students { get; set; }
        public List<CourseCategoryToCourse> CourseCategoryToCourses { get; set; }
        public List <InstructorRaiting> InstructorRaiting { get; set; }
        public InstructorSocial InstructorSocial { get; set; }


        public VmSearch Search { get; set; }

    }
}
