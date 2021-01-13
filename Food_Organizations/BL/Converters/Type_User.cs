using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
  public  class Type_User
    {
        public static DTO.Type_UserDTO GetType_UserDto(Dal.Type_User type_Users)
        {
            DTO.Type_UserDTO type_User = new DTO.Type_UserDTO();
            type_User.Type_Id = type_Users.Type_Id;
            type_User.Type_Name = type_Users.Type_Name;
           
            return type_User;
        }
        
    }
}
