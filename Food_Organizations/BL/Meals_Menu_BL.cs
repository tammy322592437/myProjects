using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
  public  class Meals_Menu_BL
    {
        public static bool AddMenu(DTO.Meals_MenuDTO m)
        {
            return Dal.Actions.Menu.AddMenu(Converters.Meals_MenuConverters.GetMeals_Menu(m));
           
        }

        public static bool UpdateMenu(Meals_MenuDTO m)
        {
            return Dal.Actions.Menu.UpdateMenu(Converters.Meals_MenuConverters.GetMeals_Menu(m));
        }

       
        public static bool RemoveItem(Meals_MenuDTO m)
        {
            return Dal.Actions.Menu.RemoveItem(Converters.Meals_MenuConverters.GetMeals_Menu(m));
        }

        public static List<DTO.Meals_MenuDTO > GetNenu()
        {
            List<DTO.Meals_MenuDTO> l = new List<Meals_MenuDTO>();
            Dal.Actions.Menu.GetMenu().ForEach(a => l.Add(Converters.Meals_MenuConverters.GetMeals_MenuDTO(a)));
            return l;
            //using (Dal.Food_OrganizationsEntities db = new Dal.Food_OrganizationsEntities())
            //{
            //    List < DTO.Meals_MenuDTO > meals = new List<DTO.Meals_MenuDTO>();
            //    var mea=db
            //}
        }

        public static List<Type_User> getUser()
        {
            List<DTO.Type_User> type_Users = new List<Type_User>();
            Dal.Actions.Menu.Get_Users().ForEach(a => type_Users.Add(Converters.Meals_MenuConverters.GetType_UserDTO(a)));
            return type_Users;

            using (Dal.FoodOrganizationsEntities db = new Dal.FoodOrganizationsEntities())
            {

                List<DTO.Type_User> groups = new List<DTO.Type_User>();
                 var openGroup = db.Type_User.ToList();//הצג רק את הקבוצות שעוד לא נסגרו
                foreach (var item in openGroup)
                {
                    groups.Add(Converters.Meals_MenuConverters.GetType_UserDTO(item));
                }

                return groups;
            }
        }

        public static bool deleteUser(int id)
        {
            return Dal.Actions.Menu.deleteUser(id);
        }

        public static bool add_user(DTO.Type_User user)
        {
          return  Dal.Actions.Menu.add_user(Converters.Meals_MenuConverters.GetType_User(user));
        }
    }
}
