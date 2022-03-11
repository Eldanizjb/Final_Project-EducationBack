using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class InstructorSocialController : Controller
    {
         
        private readonly AppDbContext _context;

        public InstructorSocialController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<InstructorSocial> model = _context.InstructorSocials.ToList();
            return View(model);
        }
        public IActionResult InstructorSocialDetail(int? Id)
        {
            if (Id != null)
            {
                InstructorSocial model2 = new();
                if (_context.InstructorSocials.Find(Id) != null)
                {
                    model2 = _context.InstructorSocials.FirstOrDefault(b => b.Id == Id);


                    return View(model2);
                }
                else
                {
                    TempData["InstructorSocialError"] = "Such an id does not exist";
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
        public IActionResult Create(InstructorSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.InstructorSocials.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.InstructorSocials.Find(id));
        }

        [HttpPost]
        public IActionResult Update(InstructorSocial model)
        {
            if (ModelState.IsValid)
            {
                _context.InstructorSocials.Update(model);
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

            InstructorSocial instructorSocial = _context.InstructorSocials.Find(id);
            if (instructorSocial == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.InstructorSocials.Remove(instructorSocial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

