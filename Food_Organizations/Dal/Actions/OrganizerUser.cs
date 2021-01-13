using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Actions
{
    public class OrganizerUser
    {
        public static FoodOrganizationsEntities db = new FoodOrganizationsEntities();
        public static bool AddOrganizerUser(Dal.Organizer o)
        {
            try
            {
                db.Organizers.Add(o);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool RemoveOrganizerUser(Dal.Organizer o)
        {
            try
            {
                db.Organizers.Remove(o);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Dal.Volunteer> sendMessageToAllTheVolunteers(int organizationKod)
        {
           using(FoodOrganizationsEntities db =new FoodOrganizationsEntities())
                try
                {
                    return db.Volunteers.Where(item => item.User.OrganizationKod == organizationKod).ToList();
                }
                catch
                {
                    return null;
                }
        }

        public static bool deleteRequest(Needy needy)
        {
            try
            {
                var q = db.Needies.FirstOrDefault(item => item.Needy_Kod == needy.Needy_Kod);
                q.User.Is_Active = false;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Dal.Organizer SignInOrganizerUser(string name, string password)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
                try
                {
                    Dal.Organizer g = new Organizer();
                   g= db.Organizers.FirstOrDefault(organizer => organizer.User.Password == password &&
                    organizer.User.Email == name && organizer.User.Is_Active == true);
                    g.User = db.Users.FirstOrDefault(x => x.User_kod == g.Organizer_Kod);
                    return g;
                }
                catch
                {
                    return null;
                }
        }

        public static string getOrganizationName(Needy needy)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
           try {
                    return db.Organizations.FirstOrDefault(item => item.Organization_Kod == needy.User.OrganizationKod).Organization_Name;
            }
                catch
                {
                    return null;
                }
        }

        public static bool updateRequsts(Needy needy)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
                try
                {
                    var q = db.Needies.FirstOrDefault(needy1 => needy1.Needy_Kod == needy.Needy_Kod );
                    q.ExpireDate = needy.ExpireDate;
                    q.User.Is_Active = needy.User.Is_Active;
                    q.AmountToHelp = needy.AmountToHelp;
                    q.QuantityUsed = needy.QuantityUsed;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
        }

        public static List<Dal.Selected_Menu_For_Help> getRequests(int organizationKod)
        {
            List<Dal.Selected_Menu_For_Help> selected_Menu_For_Helps = new List<Selected_Menu_For_Help>();
            selected_Menu_For_Helps = db.Selected_Menu_For_Help.Where(f => f.Organization_Kod == organizationKod).ToList();
            return selected_Menu_For_Helps;
        }

        public static List<Organizer> GetOrganizer()
        {
            return db.Organizers.ToList();
        }
        public static List<Dal.Needy> getDetailsNeedy(int organizationKod)
        {
            using (FoodOrganizationsEntities context = new FoodOrganizationsEntities())
                try
                {


                    List<Dal.Needy> usersDetails = new List<Dal.Needy>();
                    usersDetails = context.Needies.Where(item => item.User.OrganizationKod == organizationKod).Where(item=>item.User.Is_Active==true).ToList();
                   /// usersDetails = context.Needies.Where(item => item.User.OrganizationKod == organizationKod).ToList();
                    return usersDetails;


                }
                catch
                {
                    return null;
                }
        }
    }
}
