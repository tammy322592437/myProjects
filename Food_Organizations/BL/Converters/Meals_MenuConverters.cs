using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
   public  class Meals_MenuConverters
    {

        public static Dal.Meals_Menu GetMeals_Menu(DTO.Meals_MenuDTO meals_MenuDTO)
        {
            Dal.Meals_Menu meals_Menu = new Dal.Meals_Menu();
            meals_Menu.Amount = meals_MenuDTO.Amount;
            meals_Menu.Food_Type = meals_MenuDTO.Food_Type;
            meals_Menu.Meals_Menu_Kod = meals_MenuDTO.Meals_Menu_Kod;

            meals_Menu.Organization_Kod = meals_Menu.Organization_Kod;

            meals_Menu.Status = meals_MenuDTO.Status;
        

            return meals_Menu;
        }
        public static DTO.Food_TypeDTO GetFood_TypeDTO(Dal.Food_Type food_Type)
        {
            DTO.Food_TypeDTO food_TypeDTO = new Food_TypeDTO()
            {
                Food_Type1 = food_Type.Food_Type1,
                Food_Type_Name = food_Type.Food_Type_Name,

            };
            return food_TypeDTO;
        }
        public static DTO.Meals_MenuDTO GetMeals_MenuDTO(Dal.Meals_Menu meals_Menu)
        {
            DTO.Meals_MenuDTO meals_MenuDTO = new Meals_MenuDTO();
        
            meals_MenuDTO.Status = meals_Menu.Status;
          
            meals_MenuDTO.Organization_Kod = meals_Menu.Organization_Kod;
          
            meals_MenuDTO.Meals_Menu_Kod = meals_Menu.Meals_Menu_Kod;
            meals_MenuDTO.Food_Type = meals_Menu.Food_Type;
            meals_MenuDTO.Amount = meals_Menu.Amount;
            meals_MenuDTO.Food_Type1 = GetFood_TypeDTO(meals_Menu.Food_Type1);
            return meals_MenuDTO;

        }
        public static DTO.Type_User GetType_UserDTO(Dal.Type_User type_User)
        {
            DTO.Type_User type_Users = new Type_User();
            type_Users.Type_Id = type_User.Type_Id;
            type_Users.Type_Name = type_User.Type_Name;
            return type_Users;
        }
        public static Dal.Type_User GetType_User(DTO.Type_User type_User)
        {
            Dal.Type_User type_Users = new Dal.Type_User();
            type_Users.Type_Id = type_User.Type_Id;
            type_Users.Type_Name = type_User.Type_Name;
            return type_Users;
        }
        public static List<Dal.Meals_Menu> GetListMeals_menu(List<DTO.Meals_MenuDTO> ls)
        {
            List<Dal.Meals_Menu> dl = new List<Dal.Meals_Menu>();
            foreach (var item in ls)

            {
                dl.Add(GetMeals_Menu(item));

            }
            return dl;

        }
        public static List<DTO.Meals_MenuDTO> GetListMeals_menuDTO(List<Dal.Meals_Menu>ls)
        {
            List<DTO.Meals_MenuDTO> dl = new List<Meals_MenuDTO>();
            foreach(var item in ls)
            {
                dl.Add(GetMeals_MenuDTO(item));
            }
            return dl;
        }
    }
}
