using Final_Project_Education.Data;
using Final_Project_Education.Models;
using Final_Project_Education.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(VmSearch search )
        {
            VmBlog model = new();
            if (search == null || search.page == null || search.searchData != null || search.catId != null || search.tagId != null)
            {
                search.page = 1;
            }
            double itemCount = 3;
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "Blog");
            model.Socials = _context.Socials.ToList();
            model.Settings = _context.Settings.FirstOrDefault();
            List<Blog> blogs = _context.Blogs.Include(c => c.Comments).Include(cu => cu.CustomUser)
                                        .Include(ca => ca.BlogCategory)
                                        .Where(bc => (search.tagId != null ? bc.TagToBlogs.Any(tb => tb.TagId == search.tagId) : true)
                                               &&(search.catId != null? bc.BlogCategoryId == search.catId : true) &&
                                                  (search.searchData != null ? bc.Title.Contains(search.searchData) : true)).ToList();

            int PageCount = (int)Math.Ceiling(Convert.ToDecimal(blogs.Count / itemCount));
            model.Blogs = blogs.Skip(((int)search.page - 1) * (int)itemCount).Take((int)itemCount).ToList();
            ViewBag.PageCount = PageCount;
            ViewBag.Page = search.page;


            model.BlogCategories = _context.BlogCategories.Include("Blogs").ToList();
            model.Tags = _context.Tags.ToList();
            model.Search = search;
            return View(model);
        }

        public IActionResult BlogDetails(int? Id)
        {
            if (Id != null)
            {
                VmBlog model = new();
                if (model != null)
                {
                    ViewBag.LastestBlogs = _context.Blogs.Take(3).OrderByDescending(b => b.CreatedDate).ToList();
                    model.Settings = _context.Settings.FirstOrDefault();
                    model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "BlogDetails");
                    model.Socials = _context.Socials.ToList();
                    model.Blogs = _context.Blogs.Include("Comments").Include("CustomUser").ToList();
                    model.Tags = _context.Tags.ToList();
                    model.BlogCategories = _context.BlogCategories.Include("Blogs").ToList();
                    model.BlogDetails = _context.Blogs.Include(c => c.BlogCategory).Include(tb => tb.TagToBlogs)
                                                .ThenInclude(t => t.Tag).Include(cu => cu.CustomUser)
                                             .Include(c => c.Comments).ThenInclude(cp => cp.Commenter).FirstOrDefault(p => p.Id == Id);
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult CommentsAll(Commenter commenter)
        {
            if (ModelState.IsValid)
            {
                _context.Commenters.Add(commenter);
                _context.SaveChanges();

                Comment comment = new();
                comment.BlogId = commenter.BlogId;
                comment.CommenterId = commenter.Id;
                comment.CreatedDate = DateTime.Now;
                comment.Text = commenter.Content;

                if (commenter.CommentId > 0)
                {
                    comment.ParentCommentId = commenter.CommentId;
                }

                _context.Comments.Add(comment);
                _context.SaveChanges();
            }
            return RedirectToAction("BlogDetails", new { Id = commenter.BlogId });
        }

    }
}
