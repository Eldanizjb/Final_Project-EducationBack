﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class CustomUser : IdentityUser
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }



        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }



        public List<Blog> Blogs { get; set; }
    
        [NotMapped]
        public string RoleId { get; set; }
    }
}
