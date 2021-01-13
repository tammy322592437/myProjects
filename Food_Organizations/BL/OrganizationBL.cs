using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DTO;

namespace BL
{
    public class OrganizationBL
    {
      
        public static bool RemoveOrganization(DTO.OrganizationDTO o)
        {
            return Dal.Actions.Organization.RemoveOrganization(Converters.OrganizationConverters.GetOrganization(o));
        }

        public static bool AddOrganization(DTO.OrganizationDTO o)
        {
          return  Dal.Actions.Organization.AddOrganization(Converters.OrganizationConverters.GetOrganization(o));
        }

        public static OrganizationDTO getOrganizatioById(int id)
        {
          var o= Converters.OrganizationConverters.GetOrganizationDTO(Dal.Actions.Organization.getOrganizatioById(id));
          //  o.contentImage = GetDataFile(o.Organization_Logo);
            return o;
        }

        public static string GetDataFile(string path)
        {
            if (path != null)
            {
                byte[] Bytes = new byte[10000000];
                string filesDir = HttpContext.Current.Server.MapPath("~/UploadFile");
                string FileExtension = Path.GetExtension(path);
                string destFile = System.IO.Path.Combine(filesDir, path);
                Bytes = File.ReadAllBytes(destFile);
                
                return Convert.ToBase64String(Bytes);
            }
            return null;

        }
        public static List<OrganizationDTO> GetOrganization()
        {
            return Converters.OrganizationConverters.GetListDTO(Dal.Actions.Organization.GetOrganization());
        }
       

        public static List<OrganizerDTO> GetOrganizer()
        {
            throw new NotImplementedException();
        }
    }
}
