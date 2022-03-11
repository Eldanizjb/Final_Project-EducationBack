using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmAbout : VmLayout
    {
     public Banner Banner { get; set; }
    public List<About> Abouts { get; set; }
    public About About { get; set; }
    public List<Advice> Advices { get; set; }
    public List<Partners> Partners { get; set; }
    public List<Programs> Programs { get; set; }
    public List<Event> Events { get; set; }
    public List<Feedback> Feedbacks { get; set; }
    public List<Blog> Blogs { get; set; }
    public List<Students> Students { get; set; }
    public Commenter Commenter { get; set; }

    }
}
