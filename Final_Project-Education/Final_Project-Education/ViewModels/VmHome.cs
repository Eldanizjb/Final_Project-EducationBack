using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmHome : VmLayout
    {
        public List<CourseCategory> CourseCategories{ get; set; }
        public List<About> Abouts { get; set; }
        public List<Advice> Advices { get; set; }
        public List<Partners> Partners { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseCategoryToCourse> CourseCategoryToCourses { get; set; }
        public List<Event> Events { get; set; }
        public List<Pricing> Pricings { get; set; }
        public List<Feature> Features { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public List<Blog> Blogs { get; set; }
        public Instructor Instructor { get; set; }
        public List<InstructorRaiting> InstructorRaiting { get; set; }
        public Course Course { get; set; }
        public List<Students> Students { get; set; }


    }
}
