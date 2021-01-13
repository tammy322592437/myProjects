using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public class OrganizerConverts
    {

        public static Dal.Organizer GetOrganizer(DTO.OrganizerDTO OrganizerDTO)
        {
            Dal.Organizer Organizer = new Dal.Organizer();
            Organizer.Organizer_Id = OrganizerDTO.Organizer_Id;
            Organizer.User = UserConverters.GetUser(OrganizerDTO.User);

            return Organizer;
        }
        public static DTO.OrganizerDTO GetOrganizerDTO(Dal.Organizer Organizer)
        {
           DTO. OrganizerDTO OrganizerDTO1 = new  DTO. OrganizerDTO();
            OrganizerDTO1.Organizer_Kod = Organizer.Organizer_Kod;
            OrganizerDTO1.Organizer_Id = Organizer.Organizer_Id;
            OrganizerDTO1.User = Converters.UserConverters.userDTO(Organizer.User);
            return OrganizerDTO1;
        }
        public static List<Dal.Organizer> GetListOrganizer(List<DTO.OrganizerDTO> ls)
        {
            List<Dal.Organizer> dl = new List<Dal.Organizer>();
            foreach (var item in ls)

            {
                dl.Add(GetOrganizer(item));

            }
            return dl;

        }
        public static List<DTO.OrganizerDTO> GetListOrganizerDTO(List<Dal.Organizer> ls)
        {
            List<DTO.OrganizerDTO> dl = new List<DTO.OrganizerDTO>();
            foreach (var item in ls)
            {
                dl.Add(GetOrganizerDTO(item));
            }
            return dl;
        }
        internal static List<NeedyDTO> GetListDetailsNeedyDTO(List<Dal.Needy> getUsers)
        {
            List<DTO.NeedyDTO> getUsersDTO = new List<NeedyDTO>();
            foreach (var item in getUsers)
            {
                getUsersDTO.Add(Converters.NeedyConverters.GetNeedyDTO(item));
            }
            return getUsersDTO;
        }
        public static UserDTO GetUserDTO(User user)
        {
            UserDTO userDTO = new UserDTO()
            {
                First_Name = user.First_Name,
                Last_Name = user.Last_Name
            ,
                Email = user.Email,
                HomeTown = user.HomeTown,
                Is_Active = user.Is_Active,
                OrganizationKod = user.OrganizationKod,
                Password = user.Password,
                Telephone = user.Telephone,
                User_kod = user.User_kod,
                User_Type = user.User_Type
            };


            return userDTO;
        }
    }
}
