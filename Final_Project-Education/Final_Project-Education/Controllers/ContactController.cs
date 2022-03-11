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
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmContact model = new();
            {
                model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Contact");
                model.Socials = _context.Socials.ToList();
                model.Settings = _context.Settings.FirstOrDefault();

            };
            return View(model);
        }

        public IActionResult Message(string email1, string name, string phone, string text)
        {
            VmMessageResponse response = new VmMessageResponse();

            if ((!string.IsNullOrEmpty(email1))&&(!string.IsNullOrEmpty(name))&&(!string.IsNullOrEmpty(phone))&&(!string.IsNullOrEmpty(text)))
            {
                if ((_context.Messages.Any(s => s.Email == email1))&& (_context.Messages.Any(s => s.Fullname == name))&& (_context.Messages.Any(s => s.Phone == phone))&& (_context.Messages.Any(s => s.Text == text)))
                {
                    response.Message = false;
                    return Json(response);
                }
                else
                {
                    response.Message = true;
                    Message message = new();
                    message.CreatedDate = DateTime.Now;
                    message.Fullname = name;
                    message.Email = email1;
                    message.Phone = phone;
                    message.Text = text;

                    _context.Messages.Add(message);
                    _context.SaveChanges();

                    return Json(response);
                }
            }
            else
            {
                response.Message2 = true;
                return Json(response);
            }
        }
    }  
}

