using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Final_Project_Education.Data;
using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnviroment, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _webHostEnvironment = webHostEnviroment;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            ViewBag.Name = DateTime.Now;
            return View(_context.Blogs.OrderByDescending(o => o.CreatedDate)
                                      .Include(cu => cu.CustomUser)
                                      .Include(bc => bc.BlogCategory)
                                      .Include(tb => tb.TagToBlogs)
                                      .ThenInclude(t => t.Tag).ToList());
        }
    
        public IActionResult BlogDetail(int? Id)
        {
            if (Id != null)
            {
                ViewBag.Name = DateTime.Now;
                VmBlog model2 = new();
                if (_context.Blogs.Find(Id) != null)
                {
                    model2.BlogDetails = _context.Blogs.Include(cu => cu.CustomUser)
                                      .Include(bc => bc.BlogCategory)
                                      .Include(tb => tb.TagToBlogs)
                                      .ThenInclude(t => t.Tag).FirstOrDefault(b => b.Id == Id);
                    model2.BlogCategories = _context.BlogCategories.ToList();
                    model2.Tags = _context.Tags.ToList();

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
            ViewBag.Name = DateTime.Now;
            ViewBag.BlogCategory = _context.BlogCategories.ToList();
            ViewBag.Tag = _context.Tags.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog model)
        {
            if (ModelState.IsValid)
            {
                if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                {
                    if (model.MainImageFile.Length <= 2097152)
                    {

                        //Create Blog
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.MainImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.MainImageFile.CopyTo(stream);
                        }

                        model.MainImage = fileName;
                        model.CreatedDate = DateTime.Now;
                        model.CustomUserId = _userManager.GetUserId(User);

                        _context.Blogs.Add(model);
                        _context.SaveChanges();


                        //Create Tag to blog
                        if (model.TagToBlogsId != null && model.TagToBlogsId.Count > 0)
                        {
                            foreach (var item in model.TagToBlogsId)
                            {
                                TagToBlog tagToBlog = new();
                                tagToBlog.TagId = item;
                                tagToBlog.BlogId = model.Id;
                                _context.TagToBlogs.Add(tagToBlog);
                                _context.SaveChanges();
                            }
                       }
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        ViewBag.Category = _context.BlogCategories.ToList();
                        ViewBag.Tag = _context.Tags.ToList();
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    ViewBag.Category = _context.BlogCategories.ToList();
                    ViewBag.Tag = _context.Tags.ToList();
                    return View(model);
                }
            }

            ViewBag.Category = _context.BlogCategories.ToList();
            ViewBag.Tag = _context.Tags.ToList();
            return View(model);
        }
        public IActionResult Update(int? id)
        {
            Blog model = _context.Blogs.Include(tb => tb.TagToBlogs).ThenInclude(t => t.Tag).FirstOrDefault(b => b.Id == id);
            model.TagToBlogsId = _context.TagToBlogs.Where(tb => tb.BlogId == id).Select(a => a.TagId).ToList();
            ViewBag.Name = DateTime.Now;
            ViewBag.Category = _context.BlogCategories.ToList();
            ViewBag.Tag = _context.Tags.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Blog model)
        {
            if (ModelState.IsValid)
            {
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
                            ViewBag.Category = _context.BlogCategories.ToList();
                            ViewBag.Tag = _context.Tags.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        ViewBag.Category = _context.BlogCategories.ToList();
                        ViewBag.Tag = _context.Tags.ToList();
                        return View(model);
                    }
                }


                _context.Blogs.Update(model);
                _context.SaveChanges();

                //Delete old data
                List<TagToBlog> tagToBlogs = _context.TagToBlogs.Where(tb => tb.BlogId == model.Id).ToList();
                foreach (var item in tagToBlogs)
                {
                    _context.TagToBlogs.Remove(item);
                }
                _context.SaveChanges();

                //Create new Tag to blog
                if (model.TagToBlogsId != null && model.TagToBlogsId.Count > 0)
                {
                    foreach (var item in model.TagToBlogsId)
                    {
                        TagToBlog tagToBlog = new();
                        tagToBlog.TagId = item;
                        tagToBlog.BlogId = model.Id;
                        _context.TagToBlogs.Add(tagToBlog);
                    }

                    _context.SaveChanges();
                }
                return RedirectToAction("Index");

            }

            ViewBag.Category = _context.BlogCategories.ToList();
            ViewBag.Tag = _context.Tags.ToList();
            ViewBag.Name = DateTime.Now;
            return View(model);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Blog blog = _context.Blogs.Find(id);

            if (blog != null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(blog.MainImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", blog.MainImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
