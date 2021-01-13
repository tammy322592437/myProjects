using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public class VolunteerUserBL
    {
        public static bool AddVolunteerUser(DTO.VolunteerDTO v)
        {
            Dal.Volunteer volunteer = Converters.VolunteerConverters.GetVolunteer(v);
            bool result= Dal.Actions.VolunteerUser.AddVolunteerUser(volunteer);
            if(result)
            {
                string to = Dal.Actions.VolunteerUser.getOrganizerByVolunteer(volunteer);
                string subject = "התוסף מתנדב";
                string body = volunteer.User.First_Name + " " + volunteer.User.Last_Name + " " + "התוסף למערכת לאישור יש להיכנס למערכת";
                SendMessage s = new SendMessage();
                s.SendMail(to, subject, body);
                return true;
            }
            return false;


        }

        public static object logOut(int userKod)
        {
            var result = Dal.Actions.VolunteerUser.logOut(userKod);
            return true;
            //if(result)
            //{
            //    string to=Dal.Actions.VolunteerUser.getOrganizerByVolunteer
            //}
        }

        public static bool RemoveVolunteerUser(DTO.VolunteerDTO v)
        {
            return Dal.Actions.VolunteerUser.RemoveVolunteerUser(Converters.VolunteerConverters.GetVolunteer(v));
        }

        public static bool takeSupport(Selected_Menu_For_Help s)
        {
            return Dal.Actions.VolunteerUser.takeSupport(Converters.SelectedMenuForHelpConverts.GetSelectedMenuForHelp(s));
        }
    }
}
