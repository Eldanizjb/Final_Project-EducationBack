using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class InstructorSocial
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(30, ErrorMessage = "Maxsimum 30 simvol")]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(250)]
        public string Link { get; set; }



        public List<InstructorToSocial> InstructorToSocials { get; set; }
    }
}
