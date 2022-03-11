using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(500, ErrorMessage = "Maxsimum 500 simvol"), Required]
        public string Address { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Phone { get; set; }
        [MaxLength(50, ErrorMessage = "Maxsimum 50 simvol"), Required]
        public string Email { get; set; }
        [Column(TypeName = "ntext")]
        public string ContactInfo { get; set; }
        [MaxLength(100, ErrorMessage = "Maxsimum 100 simvol"), Required]
        public string Title { get; set; }
        [MaxLength(100, ErrorMessage = "Maxsimum 100 simvol"), Required]
        public string SupTitle { get; set; }
        [MaxLength(500), Required]
        public string LocationOnMap { get; set; }


        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        
        [MaxLength(250)]
        public string BannerImage { get; set; }
        [NotMapped]
        public IFormFile BannerImageFile { get; set; }
        [MaxLength(250)]
        public string BannerImageBack { get; set; }
        [NotMapped]
        public IFormFile BannerImageBackFile { get; set; }

        
        [MaxLength(250)]
        public string EventImage { get; set; }
        [NotMapped]
        public IFormFile EventImageFile { get; set; }

        [MaxLength(250)]
        public string FeatureImage { get; set; }
        [NotMapped]
        public IFormFile FeatureImageFile { get; set; }



        [MaxLength(250)]
        public string AboutVideo { get; set; }
        [NotMapped]
        public IFormFile AboutVideoFile { get; set; }
    }
}
