using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Actions
{
    public class NeedyUser
    {
        public static FoodOrganizationsEntities db = new FoodOrganizationsEntities();
        public static bool AddNeedyUser(Dal.Needy u)
        {
            try
            {
                db.Needies.Add(u);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string getOrganizerByNeedy(Needy needy)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
                try
                {
                    return db.Organizers.FirstOrDefault(item => item.User.OrganizationKod == needy.User.OrganizationKod).User.Email;
                }
                catch
                {
                    return null;
                }
        }

        public static bool RemoveNeedyUser(Dal.Needy u)
        {
            try
            {
                db.Needies.Remove(u);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Dal.Needy> getRequestsForSupport(int organizationKod)
        {
            return db.Needies.Where(item => item.User.OrganizationKod == organizationKod).ToList();
            // List<Needy> Needy = new List<Needy>();
            //Needy= db.Needies.Where(item => item.User.OrganizationKod == organizationKod).ToList();
            // return Needy;

        }
    }
}
