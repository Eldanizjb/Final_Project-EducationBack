using Final_Project_Education.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmSendEmail : VmLayout
    {
        [Required]
        public string sendingMessage { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}
