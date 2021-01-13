using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dal;
namespace BL
{
  public  class NeedyUserBL
    {
        public static bool AddNeedyUser(DTO.NeedyDTO u)
        {
            Dal.Needy convert = Converters.NeedyConverters.GetNeedy(u);
           bool result= Dal.Actions.NeedyUser.AddNeedyUser(convert);
            if(result )
            {
                if (u.User.TypeMessage == 0 || u.User.TypeMessage == 2)
                {
                    string to = Dal.Actions.NeedyUser.getOrganizerByNeedy(convert);
                    string subject = "התווסף נצרך";
                    string body;
                    if (u.NeedyDescribe != "")
                        body = u.User.First_Name + " " + u.User.Last_Name + " מספר ילדים  " + " " + u.Number_Of_Persons + " " + " תיאור כללי: " + u.NeedyDescribe + " לאישור יש להיכנס למערכת" + "<br>" +
                            "<a href='http://localhost:4200/'>http://localhost:4200/</a>"; 
                    else body = u.User.First_Name + " " + u.User.Last_Name + " מספר ילדים  " + " " + u.Number_Of_Persons + " " + " לאישור יש להיכנס למערכת"+"<br>"+
                            "<a href='http://localhost:4200/'>http://localhost:4200/</a>";
                    SendMessage s = new SendMessage();
                    s.SendMail(to, body, subject);
                    return true;
                }
            }
                return false;
           
        }

        public static bool RemoveNeedyUser(DTO.NeedyDTO u)
        {
            return Dal.Actions.NeedyUser.RemoveNeedyUser(Converters.NeedyConverters.GetNeedy(u));
        }
    }
}
