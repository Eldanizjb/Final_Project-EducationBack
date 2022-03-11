using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project_Education.ViewModels
{
    public class VmSearch
    {
        public int? tagId { get; set; }
        public int? catId { get; set; }
        public int? levId { get; set; }
        public int? prcId { get; set; }
        public int? sosId { get; set; }
        public int? page { get; set; }
        public string searchData { get; set; }
    }
}
