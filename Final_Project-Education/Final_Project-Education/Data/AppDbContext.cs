using Final_Project_Education.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Advice> Advices { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<Commenter> Commenters { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseCategoryToCourse> CourseCategoryToCourses { get; set; }
        public DbSet<CourseLevel> CourseLevel { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorRaiting> InstructorRaitings { get; set; }
        public DbSet<InstructorSocial> InstructorSocials { get; set; }
        public DbSet<InstructorToSocial> InstructorToSocials { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Programs> Programs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
    }
}
