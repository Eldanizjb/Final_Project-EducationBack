using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(1000, ErrorMessage = "Maxsimum 1000 simvol")]
        public string Question { get; set; }
        [MaxLength(2000, ErrorMessage = "Maxsimum 2000 simvol")]
        public string Answer { get; set; }
    }
}
