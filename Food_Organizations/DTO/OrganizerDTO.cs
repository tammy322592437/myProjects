using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrganizerDTO
    {
        public int Organizer_Kod { get; set; }
        public string Organizer_Id { get; set; }
        public  UserDTO User { get; set; }
    }
}
