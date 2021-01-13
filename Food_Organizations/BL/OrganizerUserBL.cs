using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BL
{
    public class OrganizerUserBL
    {
        public static bool AddOrganizerUser(DTO.OrganizerDTO o)
        {
            return Dal.Actions.OrganizerUser.AddOrganizerUser(Converters.OrganizerConverts.GetOrganizer(o));
        }

        public static bool RemoveOrganizerUser(DTO.OrganizerDTO o)
        {
            return Dal.Actions.OrganizerUser.AddOrganizerUser(Converters.OrganizerConverts.GetOrganizer(o));
        }

        public static bool sendMessageToAllTheVolunteers(int organizationKod)
        {
           var result= Dal.Actions.OrganizerUser.sendMessageToAllTheVolunteers(organizationKod);
            if(result!=null)
            {
                foreach ( var item in result) 
                {
                    string to = item.User.Email;
                    string subject = "הודעה";
                    string body = "יש מלא פניות בבקשה כנסו לקחת חלק";
                    SendMessage s = new SendMessage();
                    s.SendMail(to, body, subject);

                }
                return true;
            }
            return false;
        }

        public static bool deleteRequest(NeedyDTO needyDTO)
        {
            
           return Dal.Actions.OrganizerUser.deleteRequest(Converters.NeedyConverters.GetNeedy(needyDTO));
        }

        public static OrganizerDTO SignInOrganizerUser(string name, string password)
        {
          var result=Dal.Actions.OrganizerUser.SignInOrganizerUser(name, password);
            if (result != null)
                return Converters.OrganizerConverts.GetOrganizerDTO(result);
            return null;
        }

        public static bool updateRequsts(NeedyDTO needyDTO)
        {
            Dal.Needy needy = Converters.NeedyConverters.GetNeedy(needyDTO);
           bool result= Dal.Actions.OrganizerUser.updateRequsts(needy);
            if(result)
            {
                string organizationName = Dal.Actions.OrganizerUser.getOrganizationName(needy);
                string to = needyDTO.User.Email;
                string subject = "אישור בקשה";
                string body = "אושרה בקשתכם להרשם לארגון " + organizationName + "  " + "עד לתאריך" + " " + needyDTO.ExpireDate.ToString();
                SendMessage s = new SendMessage();
                s.SendMail(to, body, subject);
                return true;
            }
            return false;
        }

        public static List<NeedyDTO> getRequestsForSupport(int organizationKod)
        {
            List<DTO.NeedyDTO> l = new List<NeedyDTO>();
            var q = Dal.Actions.NeedyUser.getRequestsForSupport(organizationKod);
            q.ForEach(a => l.Add(Converters.NeedyConverters.GetNeedyDTO(a)));
            return l;
        }

        public static  List<DTO.Selected_Menu_For_Help> getRequests(int organizationKod)
        {
            List<DTO.Selected_Menu_For_Help> l = new List<Selected_Menu_For_Help>();
            Dal.Actions.OrganizerUser.getRequests(organizationKod).ForEach(a=>l.Add(Converters.SelectedMenuForHelpConverts.GetSelectedMenuForHelpDTO(a)));
            return l;
        }

        public static List<DTO.OrganizerDTO> GetOrganizer()
        {
           
            List<DTO.OrganizerDTO> l = new List<DTO.OrganizerDTO>();
            Dal.Actions.OrganizerUser.GetOrganizer().ForEach(a => l.Add(Converters.OrganizerConverts.GetOrganizerDTO(a)));
            return l;
        }
        public static List<NeedyDTO> getNeedyDetails(int organizationKod)
        {
            return Converters.OrganizerConverts.GetListDetailsNeedyDTO(Dal.Actions.OrganizerUser.getDetailsNeedy(organizationKod));
        }
    }
}
