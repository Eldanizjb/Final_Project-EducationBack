using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class FaqController : Controller
    {
        private readonly AppDbContext _context;

        public FaqController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmFaq model = new();
            {
                model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Faq");
                model.Socials = _context.Socials.ToList();
                model.Settings = _context.Settings.FirstOrDefault();
                model.FAQs = _context.FAQs.OrderByDescending(e => e.Id).ToList();
            };
            return View(model);
        }
    

    }
}
