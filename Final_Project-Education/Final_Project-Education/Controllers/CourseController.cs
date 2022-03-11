using ClosedXML.Excel;
using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(VmSearch search, bool date, bool name, bool price, bool one, bool two, bool three)
        {
            VmCourse model = new();
            if(search==null || search.page==null || search.searchData != null || search.catId != null || search.levId != null)
            {
                search.page = 1;
            }
                double itemCount = 6;
                model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Course");
                model.Socials = _context.Socials.ToList();
                model.Settings = _context.Settings.FirstOrDefault();
                List<Course>courses = _context.Courses.Include(tc => tc.CourseCategoryToCourses)
                                                          .ThenInclude(t => t.CourseCategory).Include(l => l.CourseLevel)
                                                          .Include(s => s.Students).Include(t => t.Instructor).ThenInclude(r=>r.InstructorRaitings)
                                                          .Where(bc => (search.catId != null ? bc.CourseCategoryToCourses.Any(tb => tb.CourseCategoryId == search.catId) : true)
                                                          && (search.levId != null ? bc.CourseLevelId == search.levId : true) 
                                                          && (search.prcId != null ? bc.NewPrice == search.prcId : true) 
                                                          && (search.searchData != null ? bc.Title.Contains(search.searchData) : true)).ToList();
            
                int PageCount = (int)Math.Ceiling(Convert.ToDecimal(courses.Count / itemCount));

            if (date)
            {
                model.Courses =  courses.OrderByDescending(m => m.CreatedDate).Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList(); ;
            } else if (name)
            {
                model.Courses = courses.OrderByDescending(m => m.Title).Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList(); ;
            } else if(price)
            {
                model.Courses = courses.OrderByDescending(m => m.NewPrice).Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList(); ;
            }else
            {
                model.Courses = courses.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();
            }

            if (one)
            {
                model.Courses = courses.OrderByDescending(m => m.CreatedDate).Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).Where(w=>(w.NewPrice>0)&&(w.NewPrice<=40)).ToList();

            }else
            {
                model.Courses = courses.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();
            }
            if (two)
            {
                model.Courses = courses.OrderByDescending(m => m.CreatedDate).Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).Where(w => (w.NewPrice > 40) && (w.NewPrice <= 80)).ToList();

            }else
            {
                model.Courses = courses.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();
            }
            if (three)
            {
                model.Courses = courses.OrderByDescending(m => m.CreatedDate).Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).Where(w => (w.NewPrice > 80) && (w.NewPrice <= 5000)).ToList();

            }else
            {
                model.Courses = courses.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();
            }

            int AllCount = courses.Count;

                ViewBag.PageCount = PageCount;
                ViewBag.AllCount = AllCount;
                ViewBag.Page = search.page;
                ViewBag.itemCount = itemCount;

            model.Students = _context.Students.ToList();
                model.Instructors = _context.Instructors.Include(c => c.Course).Include(r=>r.InstructorRaitings).ToList();

                model.CourseCategories = _context.CourseCategories.Include(st => st.CourseCategoryToCourses)
                                                  .ThenInclude(s => s.Course).ToList();
                model.CourseLevels = _context.CourseLevel.Include(s => s.Courses).ToList();

            model.Search = search;
                return View(model);
        }
       
        public IActionResult CourseDetails(int? Id)
        {
            if (Id != null)
            {
                VmCourse model = new();
                if (model != null)
                {
                    ViewBag.LastestCourse = _context.Courses.Take(3).OrderByDescending(b => b.CreatedDate).ToList();
                    model.Settings = _context.Settings.FirstOrDefault();
                    model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "CourseDetails");
                    model.Advices = _context.Advices.ToList();
                    model.Socials = _context.Socials.ToList();
                    model.Instructors = _context.Instructors.Include(c => c.Course).Include(r=>r.InstructorRaitings).ToList();
                    model.Courses = _context.Courses.ToList();
                    model.CourseDetails = _context.Courses.Include(tc => tc.CourseCategoryToCourses)
                                                          .ThenInclude(t => t.CourseCategory)
                                                          .Include(ti=>ti.Instructor)
                                                          .ThenInclude(r=>r.InstructorRaitings)
                                                          .Include(l => l.CourseLevel)
                                                          .Include(s=>s.Students).Include(c => c.CourseComments).ThenInclude(cp => cp.Commenter).FirstOrDefault(p => p.Id == Id);

                    model.InstructorRaiting = model.CourseDetails.Instructor.InstructorRaitings;

                    return View(model);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult CommentsAll(Commenter commenter)
        {
            if (ModelState.IsValid)
            {
                _context.Commenters.Add(commenter);
                _context.SaveChanges();

                CourseComment courseComment = new();
                courseComment.CourseId = commenter.CourseId;
                courseComment.CommenterId = commenter.Id;
                courseComment.CreatedDate = DateTime.Now;
                courseComment.Text = commenter.Content;

                if (commenter.CommentId > 0)
                {
                    courseComment.ParentCommentId = commenter.CommentId;
                }

                _context.CourseComments.Add(courseComment);
                _context.SaveChanges();
            }
            return RedirectToAction("CourseDetails", new { Id = commenter.CourseId });
        }
    }
}
