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

    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EventController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Events.Include(cu => cu.Instructor).ToList());
        }
        public IActionResult EventDetail(int? Id)
        {
            if (Id != null)
            {
                ViewBag.Name = DateTime.Now;
                VmEvent model2 = new();
                if (_context.Events.Find(Id) != null)
                {
                    model2.EventDetails = _context.Events.Include(cu => cu.Instructor).FirstOrDefault(b => b.Id == Id);
                    model2.Instructors = _context.Instructors.ToList();
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
            ViewBag.Instructor = _context.Instructors.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Event model)
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
                        model.InstructorId = 47;

                        _context.Events.Add(model);
                        _context.SaveChanges();

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        ViewBag.Instructor = _context.Instructors.ToList();

                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    ViewBag.Instructor = _context.Instructors.ToList();

                    return View(model);
                }
            }

            ViewBag.Instructor = _context.Instructors.ToList();

            return View(model);
        }
        public IActionResult Update(int? id)
        {
            ViewBag.Name = DateTime.Now;
            Event model = _context.Events.FirstOrDefault(b => b.Id == id);
            ViewBag.Instructor = _context.Instructors.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Event model)
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
                            ViewBag.Instructor = _context.Instructors.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        ViewBag.Instructor = _context.Instructors.ToList();
                        return View(model);
                    }
                }

                _context.Events.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.Name = DateTime.Now;

            ViewBag.Instructor = _context.Instructors.ToList();
            return View(model);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Event @event = _context.Events.Find(id);

            if (@event == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(@event.MainImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", @event.MainImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _context.Events.Remove(@event);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
