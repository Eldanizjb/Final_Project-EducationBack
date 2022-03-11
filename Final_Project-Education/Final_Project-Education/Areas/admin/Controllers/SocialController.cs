using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class SocialController : Controller
    {
        private readonly AppDbContext _context;

        public SocialController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Social> model = _context.Socials.ToList();
            return View(model);
        }
        public IActionResult SocialDetail(int? Id)
        {
            if (Id != null)
            {
                Social model2 = new();
                if (_context.Socials.Find(Id) != null)
                {
                    model2 = _context.Socials.FirstOrDefault(b => b.Id == Id);


                    return View(model2);
                }
                else
                {
                    TempData["SocialError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["SocialError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Social model)
        {
            if (ModelState.IsValid)
            {
                _context.Socials.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Socials.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Social model)
        {
            if (ModelState.IsValid)
            {
                _context.Socials.Update(model);
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

            Social social = _context.Socials.Find(id);
            if (social == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.Socials.Remove(social);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
