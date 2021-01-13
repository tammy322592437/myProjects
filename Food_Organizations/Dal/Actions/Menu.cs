using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Actions
{
   public class Menu
    {
        //public static Food_OrganizationsEntities db = new Food_OrganizationsEntities();
        
        public static FoodOrganizationsEntities db = new FoodOrganizationsEntities();
        public static bool AddMenu(Dal.Meals_Menu m)
        {
            try
            {
                db.Meals_Menu.Add(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateMenu(Meals_Menu meals_Menu)
        {
            
            var me = db.Meals_Menu.FirstOrDefault(c => c.Meals_Menu_Kod == meals_Menu.Meals_Menu_Kod);
            if (me != null)
            {
                me.Amount = meals_Menu.Amount;
                me.Food_Type = meals_Menu.Food_Type;
                me.Meals_Menu_Kod = meals_Menu.Meals_Menu_Kod;

                me.Organization_Kod = meals_Menu.Organization_Kod;
  
                me.Status = meals_Menu.Status;
                me.Status_Food = meals_Menu.Status_Food;
                db.SaveChanges();
                return true;
            }

            else return false;
        }
   
        public  static List<Meals_Menu> GetMenu()
        {
    
            return  db.Meals_Menu.ToList();
             
        }

        public static bool RemoveItem(Meals_Menu meals_Menu)
        {
            try
            {
                db.Meals_Menu.Remove(meals_Menu);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Dal.Type_User> Get_Users()
        {
            return db.Type_User.ToList();
        }

        public static bool add_user(Type_User type_User)
        {
            try {
                db.Type_User.Add(type_User);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public static bool deleteUser(int id)
        {
            try
            {
                var q = db.Type_User.FirstOrDefault(w => w.Type_Id == id);
                if (q == null)
                    return false;

                db.Type_User.Remove(q);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

