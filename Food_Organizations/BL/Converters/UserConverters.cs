using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
   public class UserConverters
    {
        public static Dal.User GetUser(DTO.UserDTO userDTO)
        {
            Dal.User user = new Dal.User() ;
            user.Email = userDTO.Email;
            user.First_Name = userDTO.First_Name;
            user.HomeTown = userDTO.HomeTown;
            user.Is_Active = userDTO.Is_Active;
            user.Last_Name = userDTO.Last_Name;
            user.OrganizationKod = userDTO.OrganizationKod;
            user.Password = userDTO.Password;
            user.Telephone = userDTO.Telephone;
            user.User_Type = userDTO.User_Type;
            user.TypeMessage = userDTO.TypeMessage;
           
            return user;
        }

        public static DTO.UserDTO userDTO(Dal.User user)
        {
            DTO.UserDTO userDTO = new DTO.UserDTO();
            
            userDTO.User_Type = user.User_Type;
            userDTO.User_kod = user.User_kod;
           
            userDTO.Telephone = user.Telephone;
            userDTO.Password = user.Password;
       
            userDTO.Last_Name = user.Last_Name;
            userDTO.Is_Active = user.Is_Active;
            userDTO.HomeTown = user.HomeTown;
            userDTO.First_Name = user.First_Name;
            userDTO.Email = user.Email;
            userDTO.TypeMessage = user.TypeMessage;
            return userDTO;
        }
     

    }
}
