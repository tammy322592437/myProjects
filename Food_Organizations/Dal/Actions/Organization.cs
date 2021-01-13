using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Actions
{
    public class Organization
    {
        public static FoodOrganizationsEntities db = new FoodOrganizationsEntities();

        public static bool AddOrganization(Dal.Organization organization)
        {

            try
            {
                db.Organizations.Add(organization);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public static List<Dal.Organization> GetOrganization()
        {
            return db.Organizations.ToList();
       
        }

        public static Dal.Organization getOrganizatioById(int id)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
                try
                {
                    return db.Organizations.FirstOrDefault(item=>item.Organization_Kod==id);
                }
                catch
                {
                    return null;
                }
        }

        //public static void AddOrganization(Dal.Organization o)
        //{

        //    try
        //    {
        //        db.Organizations.Add(o);
        //        db.SaveChanges();

        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}

        //public static AddOrganization(Dal.Organization o)
        //{
        //    try
        //    {
        //        db.Organizations.Add(o);
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public static bool RemoveOrganization(Dal.Organization o)
        {
            try
            {
                db.Organizations.Remove(o);
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
