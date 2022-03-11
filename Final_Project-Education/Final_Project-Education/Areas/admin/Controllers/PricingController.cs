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

    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Pricing> model = _context.Pricings.ToList();
            return View(model);
        }
        public IActionResult PricingDetail(int? Id)
        {
            if (Id != null)
            {
                Pricing model2 = new();
                if (_context.Pricings.Find(Id) != null)
                {
                    model2 = _context.Pricings.FirstOrDefault(b => b.Id == Id);

                    return View(model2);
                }
                else
                {
                    TempData["PricingError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["PricingError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pricing model)
        {
            if (ModelState.IsValid)
            {
                _context.Pricings.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Pricings.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Pricing model)
        {
            if (ModelState.IsValid)
            {
                _context.Pricings.Update(model);
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

            Pricing pricing = _context.Pricings.Find(id);
            if (pricing == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.Pricings.Remove(pricing);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
