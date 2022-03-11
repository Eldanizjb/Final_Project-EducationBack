using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Pricing
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Title { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string SupTitle { get; set; }
        [MaxLength(20, ErrorMessage = "Maxsimum 20 simvol")]
        public string Price { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Period { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Metod { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Place { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string MentorTime { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Type { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol")]
        public string Support { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
