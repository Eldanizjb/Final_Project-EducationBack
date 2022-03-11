using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmPricing model = new VmPricing
            {
                Banner = _context.Banners.FirstOrDefault(b => b.Page == "Pricing"),
                Socials = _context.Socials.ToList(),
                Settings = _context.Settings.FirstOrDefault(),
                Pricings = _context.Pricings.OrderByDescending(pr => pr.CreatedDate).Take(6).ToList(),
            };

            ViewBag.PricingTime = Request.Cookies["time"];
            return View(model);
        }
       
    }
}
