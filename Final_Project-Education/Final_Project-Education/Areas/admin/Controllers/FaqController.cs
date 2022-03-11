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

    public class FaqController : Controller
    {
        private readonly AppDbContext _context;

        public FaqController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<FAQ> model = _context.FAQs.ToList();
            return View(model);
        }
        public IActionResult FaqDetail(int? Id)
        {
            if (Id != null)
            {
                FAQ model2 = new();
                if (_context.FAQs.Find(Id) != null)
                {
                    model2 = _context.FAQs.FirstOrDefault(b => b.Id == Id);


                    return View(model2);
                }
                else
                {
                    TempData["FAQError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["FAQError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FAQ model)
        {
            if (ModelState.IsValid)
            {
                _context.FAQs.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.FAQs.Find(id));
        }

        [HttpPost]
        public IActionResult Update(FAQ model)
        {
            if (ModelState.IsValid)
            {
                _context.FAQs.Update(model);
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

            FAQ faq = _context.FAQs.Find(id);
            if (faq == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            //_context.FAQs.Remove();
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
