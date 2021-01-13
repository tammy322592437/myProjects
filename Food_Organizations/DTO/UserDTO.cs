using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public int User_kod { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string HomeTown { get; set; }
        public string Telephone { get; set; }
        public bool Is_Active { get; set; }
        public int User_Type { get; set; }
        public int OrganizationKod { get; set; }
        public int? TypeMessage { get; set; }


    }
}
