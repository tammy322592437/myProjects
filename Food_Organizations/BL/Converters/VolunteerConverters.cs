using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
  public  class VolunteerConverters
    {
        public static Dal.Volunteer GetVolunteer(DTO.VolunteerDTO volunteerdto)
        {
            Dal.Volunteer volunteer = new Dal.Volunteer();
            volunteer.Volunteer_Kod = volunteerdto.Volunteer_Kod;
           volunteer.User = UserConverters.GetUser(volunteerdto.User);
            return volunteer;
        }
        public static DTO.VolunteerDTO GetVolunteerDTO(Dal.Volunteer volunteer)
        {
            DTO.VolunteerDTO volunteerDTO = new DTO.VolunteerDTO();
            volunteerDTO.Volunteer_Kod = volunteer.Volunteer_Kod;
           
            return volunteerDTO;
        }
        public static List<Dal.Volunteer> GetListVolunteer(List<DTO.VolunteerDTO> ls)
        {
            List<Dal.Volunteer> dl = new List<Dal.Volunteer>();
            foreach (var item in ls)

            {
                dl.Add(GetVolunteer(item));

            }
            return dl;

        }
        public static List<DTO.VolunteerDTO> GetListVolunteerDTO(List<Dal.Volunteer> ls)
        {
            List<DTO.VolunteerDTO> dl = new List<DTO.VolunteerDTO>();
            foreach (var item in ls)
            {
                dl.Add(GetVolunteerDTO(item));
            }
            return dl;
        }
    }
}
