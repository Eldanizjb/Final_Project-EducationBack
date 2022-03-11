using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class HomeController : Controller
    { 
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            VmLayout model = new();
            model.Socials = _context.Socials.ToList();
            model.Settings = _context.Settings.FirstOrDefault();
            model.Subscribe = _context.Subscribes.ToList();
            model.Messages = _context.Messages.ToList();
            
            return View(model);
        }
    }
}
