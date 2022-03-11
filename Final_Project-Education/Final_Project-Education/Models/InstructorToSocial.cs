using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class InstructorToSocial
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        [ForeignKey("InsrtuctorSocial")]
        public int InstructorSocialId { get; set; }
        public InstructorSocial InstructorSocial { get; set; }
    }
}
