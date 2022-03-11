using ClosedXML.Excel;
using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class StudentsController : Controller
    {

        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(VmSearch search)
        {
            VmStudents students = new();
            if (students != null)
            {
                if (search == null || search.page == null || search.searchData != null)
                {
                    search.page = 1;
                }
            }
            double itemCount = 3;

            students.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Student List ");
            students.Settings = _context.Settings.FirstOrDefault();
            students.Courses = _context.Courses.ToList();

            List<Students> model = _context.Students.Where(bc => (search.searchData != null ? bc.Name.Contains(search.searchData) : true)).ToList();
            int PageCount = (int)Math.Ceiling(Convert.ToDecimal(model.Count / itemCount));
            students.Students = model.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();
            ViewBag.PageCount = PageCount;
            ViewBag.Page = search.page;

            students.Search = search;
            return View(students);
        }
      
    }
}
