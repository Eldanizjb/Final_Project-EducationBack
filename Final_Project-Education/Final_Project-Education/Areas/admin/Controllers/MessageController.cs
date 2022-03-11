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

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]

    public class MessageController : Controller
    {
         private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Message> subscribes = _context.Messages.ToList();
            string messageModel = JsonConvert.SerializeObject(subscribes);

            HttpContext.Session.SetString("Message", messageModel);
            return View(subscribes);
        }

       
        public IActionResult MessageDetail(int? Id)
        {
            if (Id != null)
            {
                Message model2 = new();
                if (_context.Messages.Find(Id) != null)
                {
                    model2 = _context.Messages.FirstOrDefault(b => b.Id == Id);


                    return View(model2);
                }
                else
                {
                    TempData["MessageError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["MessageError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }

        public IActionResult SendMailAll(int? Id)
        {
            if (Id != null)
            {
                if (_context.Messages.Find(Id) != null)
                {
                    var message = _context.Messages.Find(Id);
                    VmSendEmail model = new();
                    model.Message = message;
                    message.Ready = true;
                    _context.Messages.Update(message);
                    _context.SaveChanges();
                    return View(model);
                }
            }

            return RedirectToAction();
        }

        [HttpPost]
        public IActionResult SendMailAll(string MailText)
        {
            List<Message> subscribes = _context.Messages.ToList();

            foreach (var item in subscribes)
            {
                MailMessage mail = new();
                mail.From = new MailAddress("eldanizjb@code.edu.az", "CodeCampBaku");
                mail.To.Add(item.Email);
                mail.Body = MailText;
                mail.IsBodyHtml = true;
                mail.Subject = "Mesaj";

                SmtpClient smtpClient = new();
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

            Message message = _context.Messages.Find(id);
            if (message == null)
            {
                HttpContext.Session.SetString("NullDataError", "Məlumat tapılmadı");
                return RedirectToAction("Index");
            }
            _context.Messages.Remove(message);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
