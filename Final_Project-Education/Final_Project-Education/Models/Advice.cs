using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Advice
    {
        [Key]
        public int Id { get; set; }




        [MaxLength(1000, ErrorMessage = "Maxsimum 1000 simvol"), Required]
        public string Content { get; set; }
    }
}
