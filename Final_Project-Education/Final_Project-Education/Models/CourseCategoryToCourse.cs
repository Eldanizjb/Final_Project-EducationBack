using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class CourseCategoryToCourse
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("CourseCategory")]
        public int CourseCategoryId { get; set; }
        public CourseCategory CourseCategory { get; set; }
    }
}
