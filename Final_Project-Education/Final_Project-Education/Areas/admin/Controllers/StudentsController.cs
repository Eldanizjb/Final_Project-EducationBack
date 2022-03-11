using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using ClosedXML.Excel;
using Final_Project_Education.ViewModels;

namespace Final_Project_Education.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]

    public class StudentsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public StudentsController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<StuVm> studentsList = _context.Students.Include(c=>c.Course).Select(x=>new StuVm 
            {
                Name = x.Name,
                Surname = x.Surname,
                CourseId = x.CourseId,
                CreatedDate = x.CreatedDate,
                Email = x.Email,
                Graduate = x.Graduate,
                Phone = x.Phone,
                CCourse = new CursVM 
                { 
                    Title = x.Course.Title
                }
            }).ToList();

            string studentsModel = JsonConvert.SerializeObject(studentsList);

            HttpContext.Session.SetString("Students", studentsModel);
            return View(studentsList);
        }
        public IActionResult StudentsDetail(int? Id)
        {
            if (Id != null)
            {
                Students model2 = new();
                if (_context.Students.Find(Id) != null)
                {
                    model2 = _context.Students.FirstOrDefault(b => b.Id == Id);


                    return View(model2);
                }
                else
                {
                    TempData["StudentsError"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["StudentsError"] = "Id must not be null";
                return RedirectToAction("Index");
            }
        }
        public IActionResult DownloadToExel()
        {
            string studentsModel = HttpContext.Session.GetString("Students");
            List<Students> studentsList = JsonConvert.DeserializeObject<List<Students>>(studentsModel);

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("sl1");

            ws.Row(1).Height = 5;
            ws.Row(2).Height = 30;
            ws.Row(3).Height = 30;
            ws.Row(4).Height = 30;
            ws.Row(5).Height = 30;
            ws.Row(6).Height = 30;
            ws.Row(7).Height = 30;
            ws.Row(8).Height = 30;
            ws.Row(9).Height = 30;


            ws.Column("A").Width = 0.3;
            ws.Column("B").Width = 30;
            ws.Column("C").Width = 30;
            ws.Column("D").Width = 30;
            ws.Column("E").Width = 30;
            ws.Column("F").Width = 30;
            ws.Column("G").Width = 30;
            ws.Column("H").Width = 30;
            ws.Column("I").Width = 30;

            ws.Range("B2:J2").Merge();
            ws.Range("B2:J2").Value = "Students list";
            ws.Range("B2:J2").Style.Font.FontSize = 14;
            ws.Range("B2:J2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B2:J2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B2:J2").Style.Font.Bold = true;

            ws.Cell("B3").Value = "Num";
            ws.Cell("B3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("B3").Style.Font.FontColor = XLColor.White;
            ws.Cell("B3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("B3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("B3").Style.Font.Bold = true;
            ws.Cell("B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("C3").Value = "Name";
            ws.Cell("C3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("C3").Style.Font.FontColor = XLColor.White;
            ws.Cell("C3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("C3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("C3").Style.Font.Bold = true;
            ws.Cell("C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("D3").Value = "Surname";
            ws.Cell("D3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("D3").Style.Font.FontColor = XLColor.White;
            ws.Cell("D3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("D3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("D3").Style.Font.Bold = true;
            ws.Cell("D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("E3").Value = "Phone";
            ws.Cell("E3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("E3").Style.Font.FontColor = XLColor.White;
            ws.Cell("E3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("E3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("E3").Style.Font.Bold = true;
            ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("F3").Value = "Email";
            ws.Cell("F3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("F3").Style.Font.FontColor = XLColor.White;
            ws.Cell("F3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("F3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("F3").Style.Font.Bold = true;
            ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("G3").Value = "Course";
            ws.Cell("G3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("G3").Style.Font.FontColor = XLColor.White;
            ws.Cell("G3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("G3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("G3").Style.Font.Bold = true;
            ws.Cell("G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("H3").Value = "Graduate";
            ws.Cell("H3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("H3").Style.Font.FontColor = XLColor.White;
            ws.Cell("H3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("H3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("H3").Style.Font.Bold = true;
            ws.Cell("H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("I3").Value = "Date";
            ws.Cell("I3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 112, 192);
            ws.Cell("I3").Style.Font.FontColor = XLColor.White;
            ws.Cell("I3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cell("I3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Cell("I3").Style.Font.Bold = true;
            ws.Cell("I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;


            for (int i = 0; i < studentsList.Count; i++)
            {
                ws.Cell("B" + (i + 4)).Value = i + 1;
                ws.Cell("B" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell("B" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("B" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                ws.Cell("C" + (i + 4)).Value = studentsList[i].Email;
                ws.Cell("C" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Cell("C" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("C" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

                ws.Cell("D" + (i + 4)).Value = studentsList[i].Email;
                ws.Cell("D" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Cell("D" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("D" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;


                ws.Cell("E" + (i + 4)).Value = studentsList[i].Email;
                ws.Cell("E" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Cell("E" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("E" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;


                ws.Cell("F" + (i + 4)).Value = studentsList[i].Email;
                ws.Cell("F" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Cell("F" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("F" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;


                ws.Cell("G" + (i + 4)).Value = studentsList[i].Email;
                ws.Cell("G" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Cell("G" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("G" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;


                ws.Cell("H" + (i + 4)).Value = studentsList[i].Email;
                ws.Cell("H" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Cell("H" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("H" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;


                ws.Cell("I" + (i + 4)).Value = studentsList[i].Email;
                ws.Cell("I" + (i + 4)).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                ws.Cell("I" + (i + 4)).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                ws.Cell("I" + (i + 4)).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + (i + 4)).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + (i + 4)).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + (i + 4)).Style.Border.RightBorder = XLBorderStyleValues.Thin;

            }

            using (var stream = new MemoryStream())
            {
                wb.SaveAs(stream);
                var content = stream.ToArray();

                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Students List.xlsx");
            }
        }
        public IActionResult Create()
        {
            ViewBag.Course = _context.Courses.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Students model)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Error mesajlar");
            return View(model);

        }
        public IActionResult Update(int? id)
        {
            Students model = _context.Students.Include(t => t.Course).FirstOrDefault(b => b.Id == id);
            ViewBag.Course = _context.Courses.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Students model)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Course = _context.Courses.ToList();
            ModelState.AddModelError("", "Error mesajlar");
            return View(model);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            Students students = _context.Students.Find(id);

            if (students == null)
            {
                ///
            }

            
            _context.Students.Remove(students);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
