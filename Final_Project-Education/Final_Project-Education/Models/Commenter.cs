using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Commenter
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }

        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }



        [NotMapped]
        public int BlogId { get; set; }
        [NotMapped]
        public int CourseId { get; set; }
        [NotMapped]
        public int CommentId { get; set; }



        public List<Comment> Comment { get; set; }
        public List<CourseComment> CourseComments { get; set; }
    }
}
