using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class InstructorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public InstructorController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            return View(_context.Instructors
                .Include(tS => tS.InstructorToSocials)
                .ThenInclude(t => t.InstructorSocial)
                .Include(b=>b.Course).ToList());
        }
        public IActionResult InstructorDetail(int? Id)
        {
            if (Id != null)
            {
                ViewBag.Name = DateTime.Now;
                VmInstructor model2 = new();
                if (_context.Instructors.Find(Id) != null)
                {
                    model2.InstructorDetails = _context.Instructors.Include(tS => tS.InstructorToSocials)
                                            .ThenInclude(t => t.InstructorSocial)
                                            .Include(b => b.Course).FirstOrDefault(b => b.Id == Id);
                    model2.InstructorSocials = _context.InstructorSocials.ToList();

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
            ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
            ViewBag.Name = DateTime.Now;
            ViewBag.Courses = _context.Courses.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Instructor model)
        {
            if (ModelState.IsValid)
            {
                if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                {
                    if (model.MainImageFile.Length <= 2097152)
                    {

                        //Create Blog
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.MainImageFile.CopyTo(stream);
                        }

                        model.MainImage = fileName;
                        model.CreatedDate = DateTime.Now;
                        
                        //model.UserId = 1;

                        _context.Instructors.Add(model);
                        _context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
                     ViewBag.Name = DateTime.Now;
                       ViewBag.Courses = _context.Courses.ToList();

                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
                    ViewBag.Courses = _context.Courses.ToList();

                    return View(model);
                }
            }

            ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
            ViewBag.Courses = _context.Courses.ToList();

            return View(model);
        }
        public IActionResult Update(int? id)
        {
            Instructor model = _context.Instructors.Include(tS => tS.InstructorToSocials)
                                                   .ThenInclude(t => t.InstructorSocial).FirstOrDefault(b => b.Id == id);
            model.InstructorToSocialsId = _context.InstructorToSocials.Where(tb => tb.InstructorId== id)
                                                                      .Select(a => a.InstructorSocialId).ToList();
            ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
            ViewBag.Courses = _context.Courses.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Instructor model)
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
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
                            ViewBag.Courses = _context.Courses.ToList();

                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
                        ViewBag.Courses = _context.Courses.ToList();

                        return View(model);
                    }
                }
                _context.Instructors.Update(model);
                _context.SaveChanges();

                //Delete old data
                List<InstructorToSocial> instructorToSocials = _context.InstructorToSocials.Where(tb => tb.InstructorId == model.Id).ToList();
                foreach (var item in instructorToSocials)
                {
                    _context.InstructorToSocials.Remove(item);
                }
                _context.SaveChanges();

                //Create new Tag to blog
                if (model.InstructorToSocialsId != null && model.InstructorToSocialsId.Count > 0)
                {
                    foreach (var item in model.InstructorToSocialsId)
                    {
                        InstructorToSocial instructorToSocial = new();
                        instructorToSocial.InstructorSocialId = item;
                        instructorToSocial.InstructorId = model.Id;
                        _context.InstructorToSocials.Add(instructorToSocial);
                    }
                    _context.SaveChanges();
                }
               
                return RedirectToAction("Index");
            }
            ViewBag.InstructorSocial = _context.InstructorSocials.ToList();
            ViewBag.Courses = _context.Courses.ToList();

            return View(model);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Instructor instructor = _context.Instructors.Find(id);

            if (instructor == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(instructor.MainImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", instructor.MainImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _context.Instructors.Remove(instructor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
