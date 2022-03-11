using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class InstructorRaiting
    {
        [Key]
        public int Id { get; set; }
        public int Star { get; set; }
        public string? UserEmail { get; set; }
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }
        public string? EndUserId { get; set; }


        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

       
    }
}
