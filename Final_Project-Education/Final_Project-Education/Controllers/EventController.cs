using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(VmSearch search)
        {
            VmEvent model = new();
            if (search == null || search.page == null || search.searchData != null)
            {
                search.page = 1;
            }
            double itemCount = 3;  

                model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Event ");
                model.Socials = _context.Socials.ToList();
                model.Settings = _context.Settings.FirstOrDefault();
                List<Event> events = _context.Events.Where(bc => (search.searchData != null ? bc.Title.Contains(search.searchData) : true)).ToList();
                int PageCount = (int)Math.Ceiling(Convert.ToDecimal(events.Count / itemCount));
                model.Events = events.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();
                ViewBag.PageCount = PageCount;
                 ViewBag.Page = search.page;

                 model.Search = search;
                return View(model);
        }
        public IActionResult EventDetails(int? Id)
        {
            if (Id != null)
            {
                VmEvent model = new();
                if (model != null)
                {
                    ViewBag.LastestCourse = _context.Courses.Take(3).OrderByDescending(b => b.CreatedDate).ToList();
                    model.Settings = _context.Settings.FirstOrDefault();
                    model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "EventDetails");
                    model.Socials = _context.Socials.ToList();
                    model.Events = _context.Events.ToList();
                    model.EventDetails = _context.Events.Include(tc => tc.Instructor).FirstOrDefault(p => p.Id == Id);
                    //model.Courses = _context.Courses.Include(tc => tc.CourseCategoryToCourses)
                    //                                      .ThenInclude(t => t.CourseCategory)
                    //                                      .Include(s => s.Students).Include(p => p.Instructor).ToList();
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
      
    }
}
