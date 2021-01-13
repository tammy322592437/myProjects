using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Actions
{
  public  class User
    {
    
        public static bool CreateUser(Dal.User user)
        {
            using (FoodOrganizationsEntities context = new FoodOrganizationsEntities())
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                 }
                catch(Exception e)
                {
                    return false;
                }
        }

        public static bool ForgetPassword(int organizationKod, int typeUser, string mail, string passwordChange)
        {
            using (FoodOrganizationsEntities db = new FoodOrganizationsEntities())
                try
                {
                    var result = db.Users.FirstOrDefault(item => item.OrganizationKod == organizationKod &&
                      item.User_Type == typeUser && item.Email == mail);
                    result.Password =passwordChange ;
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
