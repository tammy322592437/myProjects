using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class OrganizationDTO
    {
        public int Organization_Kod { get; set; }
        public string Organization_Name { get; set; }
        public string Organization_City { get; set; }
        public string Organization_Logo { get; set; }
        public string contentImage { get; set; }
        public string Organization_Describe { get; set; }
        public int Organization_Days { get; set; }
        public int Epicenter { get; set; }

    }
}
