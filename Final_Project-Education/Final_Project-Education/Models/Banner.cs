using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(150, ErrorMessage ="Maxsimum 150 simvol"), Required]
        public string Title { get; set; }
       
        [MaxLength(30, ErrorMessage ="Maxsimum 30 simvol"), Required]
        public string Page { get; set; }

    }
}
