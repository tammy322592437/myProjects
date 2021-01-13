using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Actions
{
    public class VolunteerUser
    {
        public static FoodOrganizationsEntities db = new FoodOrganizationsEntities();
        public static bool AddVolunteerUser(Dal.Volunteer v)
        {
            try
            {
                db.Volunteers.Add(v);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string getOrganizerByVolunteer(Volunteer volunteer)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
                try
                {
                    return db.Organizers.FirstOrDefault(item => item.User.OrganizationKod == volunteer.User.OrganizationKod).User.Email;
                }
                catch
                {
                    return null;
                }
        }

        public static Dal.Volunteer logOut(int userKod)
        {
          using(FoodOrganizationsEntities db=new FoodOrganizationsEntities())
           try {
                var result = db.Volunteers.FirstOrDefault(item => item.User.User_kod == userKod);
                result.User.Is_Active = false;
                db.SaveChanges();
                    return result;
            }
                catch
                {
                    return null;
                }
        }

        public static bool RemoveVolunteerUser(Dal.Volunteer v)
        {
            try
            {
                db.Volunteers.Remove(v);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool takeSupport(Selected_Menu_For_Help selected_Menu_For_Help)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
                try
                {
                    var result = db.Selected_Menu_For_Help.FirstOrDefault(item => item.Selected_Menu_For_Help_Kod == selected_Menu_For_Help.Selected_Menu_For_Help_Kod);
                    result.Volunteer_Kod = selected_Menu_For_Help.Volunteer_Kod;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
        }
    }
}
