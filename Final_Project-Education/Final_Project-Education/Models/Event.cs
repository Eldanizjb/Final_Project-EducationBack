using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(250, ErrorMessage = "Maxsimum 250 simvol")]
        public string Title { get; set; }
        public string WorkTime { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Address { get; set; }
        [MaxLength(2000, ErrorMessage = "Maxsimum 2000 simvol")]
        public string Content { get; set; }
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
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
