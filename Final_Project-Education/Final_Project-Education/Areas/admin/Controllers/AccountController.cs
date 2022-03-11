using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    //[Authorize]

    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser>signInManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _webHostEnvironment = webHostEnvironment;
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                CustomUser newUser = new();

                newUser.Name = model.Name;
                newUser.Surname = model.Surname;
                newUser.Email = model.Email;
                newUser.UserName = model.Email;
                newUser.CreatedDate = DateTime.Now;
                
                var result = await _userManager.CreateAsync(newUser, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newUser, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(model);
                }
            }
            return View(model);
        }

        
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(VmRegister model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login ve ya parolunuz sehfdir");
                    return View(model);
                }
            }

            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult Users()
        {
            ViewBag.Name = DateTime.Now;
            VmUser model = new();
            model.CustomUsers = _context.CustomUsers.ToList();
            model.Roles = _context.Roles.ToList();
            model.UserRoles = _context.UserRoles.ToList();
            return View(model);
        }
    
        public IActionResult UpdateUser(string Id)
        {
            if (Id != null)
            {
                if (_context.CustomUsers.Find(Id) != null)
                {
                    ViewBag.Name = DateTime.Now;

                    CustomUser model2 = _context.CustomUsers.Find(Id);
                    model2.RoleId = _context.UserRoles.Where(u => u.UserId == Id).Select(r => r.RoleId).FirstOrDefault();

                    ViewBag.Roles = _context.Roles.ToList();
                    return View(model2);
                }
                else
                {
                    ViewBag.Roles = _context.Roles.ToList();

                    return RedirectToAction("Users");
                }
            }
            else
            {
                ViewBag.Roles = _context.Roles.ToList();

                return RedirectToAction("Users");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(CustomUser model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = DateTime.Now;
                CustomUser customUser = _context.CustomUsers.Find(model.Id);
                customUser.Name = model.Name;
                customUser.Surname = model.Surname;
                customUser.UserName = model.UserName;
                customUser.Address= model.Address;
                customUser.Email = model.Email;
                customUser.PhoneNumber = model.PhoneNumber;

                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            customUser.Image = ImageName;

                        }
                        else
                        {
                            ViewBag.Roles = _context.Roles.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ViewBag.Roles = _context.Roles.ToList();
                        return View(model);
                    }

                }


                IdentityUserRole<string> userRole = _context.UserRoles.FirstOrDefault(u => u.UserId == model.Id);

                if (userRole != null)
                {
                    string oldRole = _context.Roles.Find(userRole.RoleId).Name;
                    await _userManager.RemoveFromRoleAsync(customUser, oldRole);
                }
                _context.SaveChanges();

                IdentityRole identityRole = _context.Roles.Find(model.RoleId);
                if (identityRole != null)
                {
                    await _userManager.AddToRoleAsync(customUser, identityRole.Name);
                }


                _context.SaveChanges();
                return RedirectToAction("Users");
            }

            ViewBag.Roles = _context.Roles.ToList();
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult DeleteUser(int? Id)
        {
            if (Id == null)
            {
                ///
            }

            CustomUser customUser = _context.CustomUsers.Find(Id);

            if (customUser == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(customUser.Image))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", customUser.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.CustomUsers.Remove(customUser);
            _context.SaveChanges();
            return RedirectToAction("Users");
        }
        public IActionResult Roles()
        {
            ViewBag.Name = DateTime.Now;
            List<IdentityRole> roles = _context.Roles.ToList();
            return View(roles);
        }
        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(IdentityRole model)
        {
            await _roleManager.CreateAsync(model);
            return RedirectToAction("Roles");
        }
    }
}
