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

    public class AdviceController : Controller
    {
        private readonly AppDbContext _context;

        public AdviceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            List<Advice> model = _context.Advices.ToList();
            return View(model);
        }
        public IActionResult AdviceDetail(int? Id)
        {
            if (Id != null)
            {
                ViewBag.Name = DateTime.Now;
                Advice model2 = new();
                if (_context.Advices.Find(Id) != null)
                {
                    model2 = _context.Advices.FirstOrDefault(b => b.Id == Id);

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
        public IActionResult Create(Advice model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = DateTime.Now;
                _context.Advices.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Advices.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Advice model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = DateTime.Now;
                _context.Advices.Update(model);
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

            Advice advice = _context.Advices.Find(id);
            if (advice == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.Advices.Remove(advice);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
