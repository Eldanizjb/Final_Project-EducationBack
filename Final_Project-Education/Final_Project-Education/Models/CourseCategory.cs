using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class CourseCategory
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Title { get; set; }
        [MaxLength(100, ErrorMessage = "Maxsimum 100 simvol"), Required]
        public string SupTitle { get; set; }



        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(250)]
        public string ImageBack { get; set; }
        [NotMapped]
        public IFormFile ImageBackFile { get; set; }



        public List<CourseCategoryToCourse> CourseCategoryToCourses { get; set; }
    }
}
