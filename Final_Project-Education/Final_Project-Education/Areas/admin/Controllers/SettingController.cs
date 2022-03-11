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
   public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Setting> model = _context.Settings.ToList();
            return View(model);
        }
        public IActionResult SettingDetail(int? Id)
        {
            if (Id != null)
            {
                Setting model2 = new();
                if (_context.Settings.Find(Id) != null)
                {
                    model2 = _context.Settings.FirstOrDefault(b => b.Id == Id);


                    return View(model2);
                }
                else
                {
                    TempData["SettingError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["SettingError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Setting model)
        {
            //return Content(model.ImageFile.FileName + "-" + model.ImageFile.ContentType + "-" + model.ImageFile.Length,
            //               model.ImageBackFile.FileName + "-" + model.ImageBackFile.ContentType + "-" + model.ImageBackFile.Length);

            if (ModelState.IsValid)
            {
                //LogoFile
                if (model.LogoFile.ContentType == "image/jpeg" || model.LogoFile.ContentType == "image/png")
                {
                    if (model.LogoFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.LogoFile.FileName;

                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.LogoFile.CopyTo(stream);
                        }

                        model.Logo = fileName;
                        _context.Settings.Add(model);
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
                //BannerImageFile
                if (model.BannerImageFile.ContentType == "image/jpeg" || model.BannerImageFile.ContentType == "image/png")
                {
                    if (model.BannerImageFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.BannerImageFile.FileName;

                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.BannerImageFile.CopyTo(stream);
                        }

                        model.BannerImage = fileName;
                        _context.Settings.Add(model);
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
                //BannerImageBackFile 
                if (model.BannerImageBackFile.ContentType == "image/jpeg" || model.BannerImageBackFile.ContentType == "image/png")
                {
                    if (model.BannerImageBackFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.BannerImageBackFile.FileName;

                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.BannerImageBackFile.CopyTo(stream);
                        }

                        model.BannerImageBack = fileName;
                        _context.Settings.Add(model);
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
                //EventImageFile
                if (model.EventImageFile.ContentType == "image/jpeg" || model.EventImageFile.ContentType == "image/png")
                {
                    if (model.EventImageFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.EventImageFile.FileName;

                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.EventImageFile.CopyTo(stream);
                        }

                        model.EventImage = fileName;
                        _context.Settings.Add(model);
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
                //FeatureImageFile
                if (model.FeatureImageFile.ContentType == "image/jpeg" || model.FeatureImageFile.ContentType == "image/png")
                {
                    if (model.FeatureImageFile.Length <= 2097152)
                    {

                        //Create CourseCategory
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.FeatureImageFile.FileName;

                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.FeatureImageFile.CopyTo(stream);
                        }

                        model.FeatureImage = fileName;
                        _context.Settings.Add(model);
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
                _context.Settings.Add(model);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Error mesajlar");
            return View(model);
        }

        public IActionResult Update(int id)
        {
            return View(_context.Settings.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (ModelState.IsValid)
            {
                //LogoFile
                if (model.LogoFile != null)
                {
                    if (model.LogoFile.ContentType == "image/jpeg" || model.LogoFile.ContentType == "image/png")
                    {
                        if (model.LogoFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.Logo))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.Logo);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.LogoFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.LogoFile.CopyTo(stream);
                            }

                            model.Logo = fileName;
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

                //BannerImageFile
                if (model.BannerImageFile != null)
                {
                    if (model.BannerImageFile.ContentType == "image/jpeg" || model.BannerImageFile.ContentType == "image/png")
                    {
                        if (model.BannerImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.BannerImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.BannerImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.BannerImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.BannerImageFile.CopyTo(stream);
                            }

                            model.BannerImage = fileName;
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

                //BannerImageBackFile
                if (model.BannerImageBackFile != null)
                {
                    if (model.BannerImageBackFile.ContentType == "image/jpeg" || model.BannerImageBackFile.ContentType == "image/png")
                    {
                        if (model.BannerImageBackFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.BannerImageBack))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.BannerImageBack);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.BannerImageBackFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.BannerImageBackFile.CopyTo(stream);
                            }

                            model.BannerImageBack = fileName;
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

                //EventImageFile
                if (model.EventImageFile != null)
                {
                    if (model.EventImageFile.ContentType == "image/jpeg" || model.EventImageFile.ContentType == "image/png")
                    {
                        if (model.EventImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.EventImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.EventImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.EventImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.EventImageFile.CopyTo(stream);
                            }

                            model.EventImage = fileName;
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

                //FeatureImageFile
                if (model.FeatureImageFile != null)
                {
                    if (model.FeatureImageFile.ContentType == "image/jpeg" || model.FeatureImageFile.ContentType == "image/png")
                    {
                        if (model.FeatureImageFile.Length <= 2097152)
                        {
                            //Delete old image
                            if (!string.IsNullOrEmpty(model.FeatureImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.FeatureImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }

                            //Create new image
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.FeatureImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.FeatureImageFile.CopyTo(stream);
                            }

                            model.FeatureImage = fileName;
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

                _context.Settings.Update(model);
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

            Setting setting = _context.Settings.Find(id);

            if (setting == null)
            {
                ///
            }

            //Delete old image
            //LogoFile
            if (!string.IsNullOrEmpty(setting.Logo))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", setting.Logo);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            //BannerImageFile
            if (!string.IsNullOrEmpty(setting.BannerImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", setting.BannerImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            //BannerImageBackFile
            if (!string.IsNullOrEmpty(setting.BannerImageBack))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", setting.BannerImageBack);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            //EventImageFile
            if (!string.IsNullOrEmpty(setting.EventImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", setting.EventImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            //FeatureImageFile
            if (!string.IsNullOrEmpty(setting.FeatureImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", setting.FeatureImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.Settings.Remove(setting);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
