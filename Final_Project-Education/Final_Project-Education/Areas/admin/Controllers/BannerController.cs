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

    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            List<Banner> model = _context.Banners.ToList();
            return View(model);
        }
        public IActionResult BannerDetail(int? Id)
        {
            if (Id != null)
            {
                ViewBag.Name = DateTime.Now;
                Banner model2 = new();
                if (_context.Banners.Find(Id) != null)
                {
                    model2 = _context.Banners.FirstOrDefault(b => b.Id == Id);


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
        public IActionResult Create(Banner model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = DateTime.Now;
                _context.Banners.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Banners.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Banner model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = DateTime.Now;
                _context.Banners.Update(model);
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

            Banner banner = _context.Banners.Find(id);
            if (banner == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.Banners.Remove(banner);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
