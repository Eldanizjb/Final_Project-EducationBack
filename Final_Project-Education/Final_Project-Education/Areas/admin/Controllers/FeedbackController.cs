using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class FeedbackController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FeedbackController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Feedback> model = _context.Feedbacks.ToList();
            return View(model);
        }
        public IActionResult FedbackDetail(int? Id)
        {
            if (Id != null)
            {
                Feedback model2 = new();
                if (_context.Feedbacks.Find(Id) != null)
                {
                    model2 = _context.Feedbacks.FirstOrDefault(b => b.Id == Id);


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
        public IActionResult Create(Feedback model)
        {
            //return Content(model.ImageFile.FileName + "-" + model.ImageFile.ContentType + "-" + model.ImageFile.Length,
            //               model.ImageBackFile.FileName + "-" + model.ImageBackFile.ContentType + "-" + model.ImageBackFile.Length);

            if (ModelState.IsValid)
            {
                //ImageFile
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;

                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                        model.Image = fileName;
                        _context.Feedbacks.Add(model);
                        _context.SaveChanges();
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    return View(model);
                }
                _context.Feedbacks.Add(model);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Feedbacks.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Feedback model)
        {
            if (ModelState.IsValid)
            {
                //imageFile
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(stream);
                            }

                            model.Image = fileName;
                            model.CreatedDate = DateTime.Now;
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        return View(model);
                    }
                }
                _context.Feedbacks.Update(model);
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
                ///
            }

            Feedback feedback = _context.Feedbacks.Find(id);

            if (feedback == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(feedback.Image))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", feedback.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.Feedbacks.Remove(feedback);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
