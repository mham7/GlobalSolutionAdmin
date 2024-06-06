using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSolutionAdmin.Models.Dtos
{
    public class ClientDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public decimal ProfitGenerated { get; set; }
    }

   
}
