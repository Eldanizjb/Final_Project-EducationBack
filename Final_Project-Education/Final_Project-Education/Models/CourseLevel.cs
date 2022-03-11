using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class CourseLevel
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string Name { get; set; }



        public List<Course> Courses { get; set; }
    }
}
