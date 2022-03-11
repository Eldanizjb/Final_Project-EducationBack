using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Programs
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(250, ErrorMessage = "Maxsimum 250 simvol")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "Maxsimum 500 simvol")]
        public string Content { get; set; }



        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
    }
}
