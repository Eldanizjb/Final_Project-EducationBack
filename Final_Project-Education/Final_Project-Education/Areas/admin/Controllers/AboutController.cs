using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<About> model = _context.Abouts.ToList();
            return View(model);
        }
        public IActionResult AboutDetail(int? Id)
        {
            if (Id != null)
            {
                About model2 = new();
                if (_context.Abouts.Find(Id) != null)
                {
                    model2 =_context.Abouts.FirstOrDefault(b => b.Id == Id);

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
        public IActionResult Create(About model)
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
                        _context.Abouts.Add(model);
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

                //ImageBackFile
                if (model.ImageBackFile.ContentType == "image/jpeg" || model.ImageBackFile.ContentType == "image/png")
                {
                    if (model.ImageBackFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string backfileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageBackFile.FileName;


                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", backfileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageBackFile.CopyTo(stream);
                        }
                        model.ImageBack = backfileName;
                        _context.Abouts.Add(model);
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

                _context.Abouts.Add(model);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Abouts.Find(id));
        }

        [HttpPost]
        public IActionResult Update(About model)
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

                //imageBackFile
                if (model.ImageBackFile != null)
                {
                    if (model.ImageBackFile.ContentType == "image/jpeg" || model.ImageBackFile.ContentType == "image/png")
                    {
                        if (model.ImageBackFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.ImageBack))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.ImageBack);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.ImageBackFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.ImageBackFile.CopyTo(stream);
                            }

                            model.ImageBack = fileName;
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
                _context.Abouts.Update(model);
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

            About about = _context.Abouts.Find(id);

            if (about == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(about.Image))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", about.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            if (!string.IsNullOrEmpty(about.ImageBack))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", about.ImageBack);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _context.Abouts.Remove(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
