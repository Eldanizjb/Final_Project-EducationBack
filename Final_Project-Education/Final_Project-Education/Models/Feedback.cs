using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(250, ErrorMessage = "Maxsimum 250 simvol")]
        public string Fullname { get; set; }
        public string Content { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; }



        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
