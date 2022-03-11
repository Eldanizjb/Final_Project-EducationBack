using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Surname { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Position { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Title { get; set; }
        [MaxLength(2000, ErrorMessage = "Maxsimum 2000 simvol"), Required]
        public string Content { get; set; }


        public DateTime CreatedDate { get; set; }



        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }


        public List<Course> Course { get; set; }
        public List<InstructorRaiting> InstructorRaitings { get; set; }
        public List<Event> Events { get; set; }
        public List<InstructorToSocial> InstructorToSocials { get; set; }


        [NotMapped]
        public List<int> InstructorToSocialsId { get; set; }

    }
}
