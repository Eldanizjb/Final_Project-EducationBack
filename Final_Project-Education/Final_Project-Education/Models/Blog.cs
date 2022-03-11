using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(500, ErrorMessage = "Maxsimum 500 simvol"), Required]
        public string Title { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }


        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }



        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }

        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }

        public List<TagToBlog> TagToBlogs { get; set; }

        public List<Comment> Comments { get; set; }

        [NotMapped]
        public List<int> TagToBlogsId { get; set; }

    }
}
