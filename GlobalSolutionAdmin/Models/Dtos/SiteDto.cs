using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSolutionAdmin.Models.Dtos
{
   
    public class SiteDto
    {
        public string SiteName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
