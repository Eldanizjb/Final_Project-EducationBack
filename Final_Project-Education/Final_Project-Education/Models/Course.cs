using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(250, ErrorMessage = "Maxsimum 250 simvol"), Required]
        public string Title { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }
        [MaxLength(10, ErrorMessage = "Maxsimum 10 simvol"), Required]
        public string Lectures { get; set; }
        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string Duration { get; set; }
        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string Enrolled { get; set; }
        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string Language { get; set; }
       
        [Column(TypeName = "money")]
        public double OldPrice { get; set; }
        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string OldDiscountPrice { get; set; }
        [Column(TypeName = "money")]
        public double NewPrice { get; set; }
        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string NewDiscountPrice { get; set; }
        [MaxLength(20, ErrorMessage = "Maxsimum 20 simvol")]
        public string PricePercent { get; set; }
        public DateTime CreatedDate { get; set; }


        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }

        [ForeignKey("Instructor")]
        public int? InstructorId { get; set; }
        public Instructor Instructor { get; set; }


        [ForeignKey("CourseLevel")]
        public int CourseLevelId { get; set; }
        public CourseLevel CourseLevel { get; set; }

        public List<CourseCategoryToCourse> CourseCategoryToCourses { get; set; }
 
        [NotMapped]
        public Students Student { get; set; }
 
        public List<Students> Students { get; set; }

        public List<CourseComment> CourseComments { get; set; }

        [NotMapped]
        public List<int> CourseCategoryToCoursesId { get; set; }
     
    }
}
