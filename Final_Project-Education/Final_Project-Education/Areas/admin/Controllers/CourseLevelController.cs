using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class CourseLevelController : Controller
    {
        private readonly AppDbContext _context;

        public CourseLevelController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            List<CourseLevel> model = _context.CourseLevel.ToList();
            return View(model);
        }
        public IActionResult CourseLevelDetail(int? Id)
        {
            if (Id != null)
            {
                CourseLevel model2 = new();
                if (_context.CourseLevel.Find(Id) != null)
                {
                    model2 = _context.CourseLevel.FirstOrDefault(b => b.Id == Id);


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
            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseLevel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = DateTime.Now;
                _context.CourseLevel.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.CourseLevel.Find(id));
        }

        [HttpPost]
        public IActionResult Update(CourseLevel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = DateTime.Now;
                _context.CourseLevel.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                HttpContext.Session.SetString("NullIdError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }

            CourseLevel courseLevel = _context.CourseLevel.Find(id);
            if (courseLevel == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.CourseLevel.Remove(courseLevel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
