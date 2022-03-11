using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_Education.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            VmHome home = new();
            {
                home.Socials = _context.Socials.ToList();
                home.Settings = _context.Settings.FirstOrDefault();
                home.CourseCategories = _context.CourseCategories.OrderByDescending(p => p.Id).Take(6).ToList();
                home.Abouts = _context.Abouts.ToList();
                home.Advices = _context.Advices.ToList();
                home.Partners = _context.Partners.OrderByDescending(pa => pa.CreatedDate).ToList();
                home.Courses = _context.Courses.Include(st => st.Instructor).Include(tc => tc.CourseCategoryToCourses)
                                                      .ThenInclude(t => t.CourseCategory).Include(ti => ti.Instructor)
                                                      .ThenInclude(r => r.InstructorRaitings)
                                                      .Include(ss => ss.Students).ToList();
                home.CourseCategoryToCourses = _context.CourseCategoryToCourses.OrderByDescending(e => e.CourseCategory).Take(6).ToList();
                home.Events = _context.Events.OrderByDescending(e => e.CreatedDate).Take(3).ToList();
                home.Pricings = _context.Pricings.OrderByDescending(pr => pr.CreatedDate).Take(6).ToList();
                home.Features = _context.Features.OrderByDescending(f => f.CreatedDate).Take(3).ToList();
                home.Instructors = _context.Instructors.Include(st => st.InstructorToSocials).ThenInclude(s => s.InstructorSocial).Include(c => c.Course).Include(r => r.InstructorRaitings).ToList();
                home.Blogs = _context.Blogs.Include("Comments").Include("CustomUser").OrderByDescending(pr => pr.CreatedDate).Take(3).ToList();
                home.Students = _context.Students.ToList();
                home.Courses = _context.Courses.ToList();



            };
            HttpContext.Session.SetString("IsAlive", "Bizə Etibar etdiyiniz üçün təşəkkür edirik!");

            CookieOptions options = new();

            options.Expires = DateTime.Now.AddDays(45);
            
            Response.Cookies.Append("time", "Endirimlərimiz bir ay davam edir", options);
            return View(home);
        }
        public IActionResult Subscribe(string email)
        {
            VmSubscribeResponse response = new();

            if (!string.IsNullOrEmpty(email))
            {
                if (_context.Subscribes.Any(s => s.Email == email))
                {
                    response.Status = false;
                    return Json(response);
                }
                else
                {
                    response.Status = true;
                    Subscribe subscribe = new();
                    subscribe.CreatedDate = DateTime.Now;
                    subscribe.Email = email;

                    _context.Subscribes.Add(subscribe);
                    _context.SaveChanges();

                    return Json(response);
                    
                }
            }
            else
            {
                response.Status2 = true;
                return Json(response);
            }
        }

    }
}
