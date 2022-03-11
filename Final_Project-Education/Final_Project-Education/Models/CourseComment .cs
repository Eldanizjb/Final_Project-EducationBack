using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class CourseComment
    {
        [Key]
        public int Id { get; set; }



        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }



        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Commenter")]
        public int? CommenterId { get; set; }
        public Commenter Commenter { get; set; }

        [ForeignKey("ParentComment")]
        public int? ParentCommentId { get; set; }
        public CourseComment ParentComment { get; set; }
    }
}
