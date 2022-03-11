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

    public class ProgramsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProgramsController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Programs> model = _context.Programs.ToList();
            return View(model);
        }
        public IActionResult ProgramsDetail(int? Id)
        {
            if (Id != null)
            {
                Programs model2 = new();
                if (_context.Programs.Find(Id) != null)
                {
                    model2 = _context.Programs.FirstOrDefault(b => b.Id == Id);


                    return View(model2);
                }
                else
                {
                    TempData["ProgramsError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["ProgramsError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Programs model)
        {
            //return Content(model.MainImage.FileName + "-" + model.MainImage.ContentType + "-" + model.MainImage.Length);

            if (ModelState.IsValid)
            {
                //ImageFile
                if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                {
                    if (model.MainImageFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;

                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.MainImageFile.CopyTo(stream);
                        }

                        model.MainImage = fileName;
                        _context.Programs.Add(model);
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
                _context.Programs.Add(model);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }
        public IActionResult Update(int id)
        {
            return View(_context.Programs.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Programs model)
        {
            if (ModelState.IsValid)
            {
                //imageFile
                if (model.MainImageFile != null)
                {
                    if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                    {
                        if (model.MainImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.MainImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.MainImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.MainImageFile.CopyTo(stream);
                            }

                            model.MainImage = fileName;
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
                _context.Programs.Update(model);
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

            Programs programs = _context.Programs.Find(id);

            if (programs == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(programs.MainImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", programs.MainImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _context.Programs.Remove(programs);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }



}
