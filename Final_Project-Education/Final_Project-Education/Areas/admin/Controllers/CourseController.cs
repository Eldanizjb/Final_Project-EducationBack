using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CourseController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            return View(_context.Courses.OrderByDescending(o => o.CreatedDate)
                                        .Include(tb => tb.CourseCategoryToCourses)
                                        .ThenInclude(t => t.CourseCategory)
                                        .Include(t => t.CourseLevel)
                                        .Include(s=>s.Instructor).ToList());
        }
        public IActionResult CourseDetail(int? Id)
        {
            if (Id != null)
            {
                ViewBag.Name = DateTime.Now;
                VmCourse model2 = new();
                if (_context.Courses.Find(Id) != null)
                {
                    model2.CourseDetails = _context.Courses.Include(tb => tb.CourseCategoryToCourses)
                                        .ThenInclude(t => t.CourseCategory)
                                        .Include(t => t.CourseLevel)
                                        .Include(s => s.Instructor).FirstOrDefault(b => b.Id == Id);
                    model2.CourseCategories = _context.CourseCategories.ToList();

                    return View(model2);
                }
                else
                {
                    TempData["BlogError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["BlogError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Create()
        {
            ViewBag.Name = DateTime.Now;
            ViewBag.CourseCategory = _context.CourseCategories.ToList();
            ViewBag.CourseLevel = _context.CourseLevel.ToList();
            ViewBag.Instructor = _context.Instructors.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Course model)
        {
            if (ModelState.IsValid)
            {
                if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                {
                    if (model.MainImageFile.Length <= 2097152)
                    {

                        //Create Course
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.MainImageFile.CopyTo(stream);
                        }

                        model.MainImage = fileName;
                        model.CreatedDate = DateTime.Now;
                        //model.InstructorId = 1;

                        _context.Courses.Add(model);
                        _context.SaveChanges();

                        if (model.CourseCategoryToCoursesId != null && model.CourseCategoryToCoursesId.Count > 0)
                        {
                            foreach (var item in model.CourseCategoryToCoursesId)
                            {
                                CourseCategoryToCourse courseCategoryToCourse = new();
                                courseCategoryToCourse.CourseCategoryId = item;
                                courseCategoryToCourse.CourseId = model.Id;
                                _context.CourseCategoryToCourses.Add(courseCategoryToCourse);
                                _context.SaveChanges();
                            }
                        }

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        ViewBag.CourseCategory = _context.CourseCategories.ToList();
                        ViewBag.CourseLevel = _context.CourseLevel.ToList();
                        ViewBag.Instructor = _context.Instructors.ToList();

                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    ViewBag.CourseCategory = _context.CourseCategories.ToList();
                    ViewBag.CourseLevel = _context.CourseLevel.ToList();
                    ViewBag.Instructor = _context.Instructors.ToList();

                    return View(model);
                }
            }

            ViewBag.CourseCategory = _context.CourseCategories.ToList();
            ViewBag.CourseLevel = _context.CourseLevel.ToList();
            ViewBag.Instructor = _context.Instructors.ToList();

            return View(model);
       
        }
        public IActionResult Update(int? id)
        {
            Course model = _context.Courses.Include(tc => tc.CourseCategoryToCourses).ThenInclude(t => t.CourseCategory).Include(t => t.CourseLevel).FirstOrDefault(b => b.Id == id);
            model.CourseCategoryToCoursesId = _context.CourseCategoryToCourses.Where(tb => tb.CourseId == id).Select(a => a.CourseCategoryId).ToList();
            ViewBag.Name = DateTime.Now;
            ViewBag.CourseCategory = _context.CourseCategories.ToList();
            ViewBag.CourseLevel = _context.CourseLevel.ToList();
            ViewBag.Instructor = _context.Instructors.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Course model)
        {
            if (ModelState.IsValid)
            {
                if (model.MainImageFile != null)
                {
                    if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                    {
                        if (model.MainImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.MainImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.MainImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.MainImageFile.CopyTo(stream);
                            }
                            model.MainImage = fileName;
                            model.CreatedDate = DateTime.Now;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            ViewBag.CourseCategory = _context.CourseCategories.ToList();
                            ViewBag.CourseLevel = _context.CourseLevel.ToList();
                            ViewBag.Instructor = _context.Instructors.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        ViewBag.CourseCategory = _context.CourseCategories.ToList();
                        ViewBag.CourseLevel = _context.CourseLevel.ToList();
                        ViewBag.Instructor = _context.Instructors.ToList();

                        return View(model);
                    }
                }
                _context.Courses.Update(model);
                _context.SaveChanges();

                //Delete old data
                List<CourseCategoryToCourse> courseCategoryToCourses = _context.CourseCategoryToCourses.Where(tb => tb.CourseId == model.Id).ToList();
                foreach (var item in courseCategoryToCourses)
                {
                    _context.CourseCategoryToCourses.Remove(item);
                }
                
                _context.SaveChanges();

                //Create new Tag to course
                if (model.CourseCategoryToCoursesId != null && model.CourseCategoryToCoursesId.Count > 0)
                {
                    foreach (var item in model.CourseCategoryToCoursesId)
                    {
                        CourseCategoryToCourse courseCategoryToCourse = new();
                        courseCategoryToCourse.CourseCategoryId = item;
                        courseCategoryToCourse.CourseId = model.Id;
                        _context.CourseCategoryToCourses.Add(courseCategoryToCourse);
                    }
                    _context.SaveChanges();
                }
              

                return RedirectToAction("Index");

            }
            ViewBag.CourseCategory = _context.CourseCategories.ToList();
            ViewBag.Name = DateTime.Now;
            ViewBag.CourseLevel = _context.CourseLevel.ToList();
            ViewBag.Instructor = _context.Instructors.ToList();
            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Course course = _context.Courses.Find(id);

            if (course == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(course.MainImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", course.MainImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
