using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Selected_Menu_For_Help
    {
        public int Selected_Menu_For_Help_Kod { get; set; }
        public int Meals_Menu_Kod { get; set; }
        public Nullable<int> Volunteer_Kod { get; set; }
        public System.DateTime Application_Date { get; set; }
        public int Needy_Kod { get; set; }
        public int Organizer_Kod { get; set; }
        public int Organization_Kod { get; set; }

        public Meals_MenuDTO  Meals_Menu { get; set; }
        public  NeedyDTO Needy { get; set; }
        public  OrganizationDTO Organization { get; set; }
        public  OrganizerDTO Organizer { get; set; }
        public  VolunteerDTO Volunteer { get; set; }
    }
}
