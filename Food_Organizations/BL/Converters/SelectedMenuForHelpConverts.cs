using System;
using Dal;
using DTO;

namespace BL.Converters
{
    internal class SelectedMenuForHelpConverts
    {
       public static DTO.Selected_Menu_For_Help GetSelectedMenuForHelpDTO(Dal.Selected_Menu_For_Help a)
        {
            DTO.Selected_Menu_For_Help dTO = new DTO.Selected_Menu_For_Help()
            {
                Application_Date = a.Application_Date,
                Meals_Menu_Kod = a.Meals_Menu_Kod,
                Needy_Kod = a.Needy_Kod,
                Organization_Kod = a.Organization_Kod,
                Organizer_Kod = a.Organizer_Kod,
                Selected_Menu_For_Help_Kod = a.Selected_Menu_For_Help_Kod,
                Volunteer_Kod=a.Volunteer_Kod,
               
                Organizer=OrganizerConverts.GetOrganizerDTO(a.Organizer),
                Organization=OrganizationConverters.GetOrganizationDTO(a.Organization),
                Meals_Menu=Meals_MenuConverters.GetMeals_MenuDTO(a.Meals_Menu),
                Needy=NeedyConverters.GetNeedyDTO(a.Needy)
                
           

                
            };
            if (a.Volunteer != null)
                dTO.Volunteer = VolunteerConverters.GetVolunteerDTO(a.Volunteer);
            else dTO.Volunteer = null;
            return dTO;
        }

        public static Dal.Selected_Menu_For_Help GetSelectedMenuForHelp(DTO.Selected_Menu_For_Help a)
        {
            Dal.Selected_Menu_For_Help sDal = new Dal.Selected_Menu_For_Help()
            {
                Application_Date = a.Application_Date,
                Meals_Menu_Kod = a.Meals_Menu_Kod,
                Needy_Kod = a.Needy_Kod,
                Organization_Kod = a.Organization_Kod,
                Organizer_Kod = a.Organizer_Kod,
                Selected_Menu_For_Help_Kod = a.Selected_Menu_For_Help_Kod,
                Volunteer_Kod = a.Volunteer_Kod,

                Organizer = OrganizerConverts.GetOrganizer(a.Organizer),
                Organization = OrganizationConverters.GetOrganization(a.Organization),
                Meals_Menu = Meals_MenuConverters.GetMeals_Menu(a.Meals_Menu),
                Needy = NeedyConverters.GetNeedy(a.Needy)

            };
            if (a.Volunteer != null)
                sDal.Volunteer = VolunteerConverters.GetVolunteer(a.Volunteer);
            else sDal.Volunteer = null;
            return sDal;
        }
    }
}