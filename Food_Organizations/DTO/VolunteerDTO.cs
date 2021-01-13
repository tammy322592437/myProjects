using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VolunteerDTO
    {
        public int Volunteer_Kod { get; set; }
        public UserDTO User { get; set; }
    }
}
