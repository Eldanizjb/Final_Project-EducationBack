using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewComponents
{
    public class VcFeedback: ViewComponent
    {
        private readonly AppDbContext _context;

        public VcFeedback(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<Feedback> model = _context.Feedbacks.OrderByDescending(fe => fe.CreatedDate).Take(3).ToList();

           return View(model);
        }
    }
}
