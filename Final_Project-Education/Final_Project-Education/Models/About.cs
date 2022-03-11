using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }


       

        [MaxLength(250, ErrorMessage = "Maxsimum 250 simvol"), Required ]
        public string Title { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }



        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(250)]
        public string ImageBack { get; set; }
        [NotMapped]
        public IFormFile ImageBackFile { get; set; }
    }
}
