using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new();
            {
                model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "About");
                model.Socials = _context.Socials.ToList();
                model.Settings = _context.Settings.FirstOrDefault();
                model.Abouts = _context.Abouts.ToList();
                model.Advices = _context.Advices.ToList();
                model.Partners = _context.Partners.OrderByDescending(pa => pa.CreatedDate).Take(6).ToList();
                model.Events = _context.Events.OrderByDescending(e => e.CreatedDate).Take(3).ToList();
                model.Blogs = _context.Blogs.Include(c => c.Comments).OrderByDescending(pr => pr.CreatedDate).Take(3).ToList();
                model.Programs = _context.Programs.ToList();
                model.Students = _context.Students.ToList();
            };

            ViewBag.Session = HttpContext.Session.GetString("IsAlive");
            return View(model);
        }
     

    }
}
