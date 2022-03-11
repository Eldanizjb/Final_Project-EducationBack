using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public InstructorController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
       
        public IActionResult Index(VmSearch search)
        {
            VmInstructor model = new();
            if (search == null || search.page == null || search.searchData != null)
            {
                search.page = 1;
            }
            double itemCount = 8;
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Instructor");
            model.Socials = _context.Socials.ToList();
            model.Settings = _context.Settings.FirstOrDefault();
            List<Instructor> instructor = _context.Instructors.Include(tc => tc.InstructorToSocials).ThenInclude(s => s.InstructorSocial)
                                                       .Where(bc => (search.sosId != null ? bc.InstructorToSocials.Any(tb => tb.InstructorSocialId == search.sosId) : true)
                                                       && (search.searchData != null ? bc.Title.Contains(search.searchData) : true)).ToList();

            int PageCount = (int)Math.Ceiling(Convert.ToDecimal(instructor.Count / itemCount));
            model.Instructors = instructor.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();


            ViewBag.PageCount = PageCount;
            ViewBag.Page = search.page;
            ViewBag.itemCount = itemCount;
            model.InstructorSocials = _context.InstructorSocials.Include(st => st.InstructorToSocials)
                                              .ThenInclude(s => s.Instructor).ToList();
            model.Search = search;
            return View(model);

        }
        public IActionResult InstructorDetails(int? Id)
        {
            if (Id != null)
            {
                VmInstructor model = new();
                if (model != null)
                {
                    ViewBag.LastestCourse = _context.Courses.Take(3).OrderByDescending(b => b.CreatedDate).ToList();
                    model.Settings = _context.Settings.FirstOrDefault();
                    model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "InstructorDetails");
                    model.Socials = _context.Socials.ToList();
                    model.Instructors = _context.Instructors.Include(st => st.InstructorToSocials).ThenInclude(s => s.InstructorSocial).ToList();
                    model.Courses = _context.Courses.Include("Instructor").OrderByDescending(c => c.CreatedDate).ToList();

                    model.InstructorDetails = _context.Instructors.Include(r => r.InstructorRaitings)
                                                                  .Include(st => st.InstructorToSocials)
                                                                  .ThenInclude(s => s.InstructorSocial)
                                                                  .Include(c => c.Course).ThenInclude(ss => ss.Students).Include(c => c.Course).ThenInclude(tc => tc.CourseCategoryToCourses)
                                                                  .ThenInclude(t => t.CourseCategory).FirstOrDefault(p => p.Id == Id);
                    model.InstructorRaiting = model.InstructorDetails.InstructorRaitings;

                    return View(model);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult RaitingStar(string ratingValue, string teacherId)
        {
            int instid = Int16.Parse(teacherId);
            int ratval = Int16.Parse(ratingValue);
            InstructorRaiting raiting = new();

            raiting.Star = ratval;
            raiting.InstructorId = instid;
            _context.InstructorRaitings.Add(raiting);
            _context.SaveChanges();

            return Json(raiting);
            
        }

        //public IActionResult GetInstructorInfo(int? id)
        //{
        //    if (id != null)
        //    {
        //        if (_context.Instructors.Find(id) != null)
        //        {
        //            Instructor instructorGet = new();
        //            instructorGet = _context.Instructors.Include(r => r.InstructorRaitings)
        //                                                          .Include(st => st.InstructorToSocials)
        //                                                          .ThenInclude(s => s.InstructorSocial)
        //                                                          .Include(c => c.Course).ThenInclude(ss => ss.Students).Include(c => c.Course).ThenInclude(tc => tc.CourseCategoryToCourses)
        //                                                          .ThenInclude(t => t.CourseCategory).FirstOrDefault(p => p.Id == id);

        //            return Json(new { data = instructorGet });
        //        }
        //    }

        //    return Json(false);
        //}

        //public IActionResult RaitingStar(string userEmail, string userName, string userSurname, string productId, string ratingValue)
        //{
        //    VmResponse response = new();

        //    if (User.Identity.IsAuthenticated && userEmail == "user" && userName == "user" && userSurname == "user")
        //    {

        //        int prid = Int16.Parse(productId);
        //        int ratval = Int16.Parse(ratingValue);
        //        if (_context.Instructors.Find(prid) != null)
        //        {
        //            if (ratval >= 1 && ratval <= 5)
        //            {

        //                InstructorRaiting ratingStars = new();

        //                var usrM = _context.CustomUsers.Find(_userManager.GetUserId(User)).Email;
        //                var usrN = _context.CustomUsers.Find(_userManager.GetUserId(User)).Name;
        //                var usrS = _context.CustomUsers.Find(_userManager.GetUserId(User)).Surname;

        //                var hasIp = _context.InstructorRaitings.Where(r => r.InstructorId == prid).Any(p => (p.UserEmail == usrM) && (p.UserName == usrN) && (p.UserSurname == usrS));
        //                if (hasIp)
        //                {
        //                    _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().InstructorId = prid;
        //                    _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().Star = ratval;
        //                    _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().UserEmail = usrM;

        //                    _context.SaveChanges();

        //                    response.Changed = "change";
        //                    response.StarsCount = _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().Star;
        //                    response.Instructors = _context.Instructors.Include(pr => pr.InstructorRaitings).Where(r => r.Id == prid).ToList();

        //                    return Json(response);
        //                }
        //                else
        //                {
        //                    ratingStars.InstructorId = prid;
        //                    ratingStars.Star = ratval;
        //                    ratingStars.UserEmail = usrM;
        //                    ratingStars.UserName = usrN;
        //                    ratingStars.UserSurname = usrS;
        //                    _context.InstructorRaitings.Add(ratingStars);
        //                    _context.SaveChanges();

        //                    response.Success = "ok";
        //                    response.StarsCount = _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().Star;
        //                    response.Instructors = _context.Instructors.Include(pr => pr.InstructorRaitings).Where(r => r.Id == prid).ToList();
        //                    return Json(response);
        //                }


        //            }
        //            else
        //            {
        //                response.Error = "error";
        //                return Json(response);
        //            }


        //        }
        //        else
        //        {
        //            response.Error = "error";
        //            return Json(response);
        //        }

        //    }
        //    else
        //    {
        //        if (userEmail != null)
        //        {
        //            int prid = Int16.Parse(productId);
        //            int ratval = Int16.Parse(ratingValue);
        //            if (_context.Instructors.Find(prid) != null)
        //            {
        //                if (ratval >= 1 && ratval <= 5)
        //                {

        //                    InstructorRaiting ratingStars = new();
        //                    var hasIp = _context.InstructorRaitings.Where(r => r.InstructorId == prid).Any(p => (p.UserEmail == userEmail) && (p.UserName == userName) && (p.UserSurname == userSurname));
        //                    if (hasIp)
        //                    {
        //                        _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().InstructorId = prid;
        //                        _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().Star = ratval;
        //                        _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().UserEmail = userEmail;

        //                        _context.SaveChanges();

        //                        response.Changed = "change";
        //                        response.StarsCount = _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().Star;
        //                        response.Instructors = _context.Instructors.Include(pr => pr.InstructorRaitings).Where(r => r.Id == prid).ToList();

        //                        return Json(response);
        //                    }
        //                    else
        //                    {
        //                        ratingStars.InstructorId = prid;
        //                        ratingStars.Star = ratval;
        //                        ratingStars.UserEmail = userEmail;
        //                        ratingStars.UserName = userName;
        //                        ratingStars.UserSurname = userSurname;
        //                        _context.InstructorRaitings.Add(ratingStars);
        //                        _context.SaveChanges();

        //                        response.Success = "ok";
        //                        response.StarsCount = _context.InstructorRaitings.Where(r => r.InstructorId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().Star;
        //                        response.Instructors = _context.Instructors.Include(pr => pr.InstructorRaitings).Where(r => r.Id == prid).ToList();
        //                        return Json(response);
        //                    }


        //                }
        //                else
        //                {
        //                    response.Error = "error";
        //                    return Json(response);
        //                }


        //            }
        //            else
        //            {
        //                response.Error = "error";
        //                return Json(response);
        //            }
        //        }
        //        else
        //        {
        //            response.Error = "error";
        //            return Json(response);
        //        }
        //    }





        //}

        //public IActionResult RefreshRating(string userEmail)
        //{


        //    VmResponse response = new();
        //    response.InstructorRaitingsCount = _context.InstructorRaitings.Where(r => r.UserEmail == userEmail).ToList();



        //    return Json(response);



        //}
    }
}