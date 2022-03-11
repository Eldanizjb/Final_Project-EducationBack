using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Students 
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Surname { get; set; }
        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol"), Required]
        public string Phone { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Email { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Graduate { get; set; }


        public DateTime CreatedDate { get; set; }


        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
