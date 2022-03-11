using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmLayout
    {
        public Setting Settings { get; set; }
        public List<Social> Socials { get; set; }
        public Subscribe Subscribes { get; set; }
        public List<Subscribe> Subscribe { get; set; }
        public List<Message> Messages { get; set; }
        public Message Message { get; set; }


    }
}
