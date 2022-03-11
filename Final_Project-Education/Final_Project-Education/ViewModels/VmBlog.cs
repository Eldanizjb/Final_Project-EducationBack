using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmBlog : VmLayout
    {
        public Banner Banner { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public List<Tag>  Tags { get; set; }
        public Commenter Commenter { get; set; }
        public Blog BlogDetails { get; set; }
        public VmSearch Search { get; set; }

    }
}
