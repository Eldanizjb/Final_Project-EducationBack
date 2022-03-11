using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]

    public class SubscribeController : Controller
    {
         private readonly AppDbContext _context;

        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Subscribe> subscribes = _context.Subscribes.ToList();
            string subscribeModel = JsonConvert.SerializeObject(subscribes);

            HttpContext.Session.SetString("Subscribe", subscribeModel);
            return View(subscribes);
        }
        public IActionResult SubscribeDetail(int? Id)
        {
            if (Id != null)
            {
                Subscribe model2 = new();
                if (_context.Subscribes.Find(Id) != null)
                {
                    model2 = _context.Subscribes.FirstOrDefault(b => b.Id == Id);
                    return View(model2);
                }
                else
                {
                    TempData["SubscribeError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["SubscribeError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        public IActionResult SendMailAll()
        {
            return View(_context.Subscribes.ToList());
        }

        [HttpPost]
        public IActionResult SendMailAll(string MailText)
        {
            List<Subscribe> subscribes = _context.Subscribes.ToList();

            foreach (var item in subscribes)
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("eldanizjb@code.edu.az", "CodeCampBaku");
                mail.To.Add(item.Email);
                mail.Body = MailText;
                mail.IsBodyHtml = true;
                mail.Subject = "Mesaj";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("eldanizjb@code.edu.az", "M02052014m");

                smtpClient.Send(mail);
            }

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                HttpContext.Session.SetString("NullIdError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }

            Subscribe subscribes = _context.Subscribes.Find(id);
            if (subscribes == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.Subscribes.Remove(subscribes);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
