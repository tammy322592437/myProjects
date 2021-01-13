using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public class OrganizationConverters
    {
        public static Organization GetOrganization(OrganizationDTO organizationDTO)
        {
            Organization organization = new Organization();
          
          
            organization.Organization_City = organizationDTO.Organization_City;
           
       
            
            organization.Organization_Kod = organizationDTO.Organization_Kod;
            organization.Organization_Logo = organizationDTO.Organization_Logo;
            organization.Organization_Name = organizationDTO.Organization_Name;
 organization.Organization_Describe = organizationDTO.Organization_Describe;

         
            return organization;
        }

        public static List<OrganizationDTO> GetListDTO(List<Dal.Organization> organizations)
        {
            List<DTO.OrganizationDTO> organizationDTO = new List<OrganizationDTO>();
            foreach (var item in organizations)
            {
              organizationDTO.Add(GetOrganizationDTO(item));
            }
            return organizationDTO;
        }
        public static OrganizationDTO GetOrganizationDTO(Organization organization)
        {
            OrganizationDTO organizationDTO = new OrganizationDTO();
          
   
            organizationDTO.Organization_City = organization.Organization_City;
           
        

            organizationDTO.Organization_Kod = organization.Organization_Kod;
            organizationDTO.Organization_Logo = organization.Organization_Logo;
            organizationDTO.Organization_Name = organization.Organization_Name;
    
                      organizationDTO.Organization_Describe = organization.Organization_Describe;
            return organizationDTO;
        }

    }
}
