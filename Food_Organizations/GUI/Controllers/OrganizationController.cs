using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace GUI.Controllers
{
    [RoutePrefix("api/Organization")]
    public class OrganizationController : ApiController
    {
        [Route("getOrganizatioById"), HttpGet]
        public DTO.OrganizationDTO getOrganizatioById(int id)
        {
            return BL.OrganizationBL.getOrganizatioById(id);
        }

        [Route("GetOrganization")]
        [HttpGet]
        public List<DTO.OrganizationDTO> GetOrganization()
        {
             var result =BL.OrganizationBL.GetOrganization();
            return result;
        }
        //  [Route("CreateOrganization")]
        //[HttpPost]
        //public IHttpActionResult  AddOrganization([FromBody] DTO.OrganizationDTO o)
        //{
        //    var result = BL.OrganizationBL.AddOrganization(o);

        //    if (result)

        //        return Ok();
        //    return BadRequest();


        //}
        [Route("PostAddOrganization")]
        [HttpPost]
        async public Task<IHttpActionResult> PostAddOrganization()
        {
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }
            string root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            await Request.Content.ReadAsMultipartAsync(provider);

            NameValueCollection formdata = provider.FormData;
            ///כל האוביקט שנשלח
            DTO.OrganizationDTO organization = JsonConvert.DeserializeObject<DTO.OrganizationDTO>(formdata["Organization"].ToString());
            //uploadFile
            string filesDir = HttpContext.Current.Server.MapPath("~/UploadFile");
            foreach (MultipartFileData file in provider.FileData)
            {   
                var fileName = file.Headers.ContentDisposition.FileName.Replace("\"", string.Empty);
             
                byte[] documentData = File.ReadAllBytes(file.LocalFileName);
                string destFile = System.IO.Path.Combine(filesDir, fileName);
                string d = fileName.ToString();
                string n = organization.Organization_Name;


                organization.Organization_Logo = d;
              

                if (Directory.GetFiles(filesDir, fileName).Length == 0)
                {
                    File.Copy(file.LocalFileName, destFile);
                }
            }

            var result = BL.OrganizationBL.AddOrganization(organization);

              if (result)

                  return Ok();
              return BadRequest();
        }
        [Route("RemoveOrganization")]
        [HttpDelete]
        public IHttpActionResult RemoveOrganization([FromBody] DTO.OrganizationDTO o)
        {
            
            var result = BL.OrganizationBL.RemoveOrganization(o);

            if (result)

                return Ok();
            return BadRequest();
        }
       
        //[Route("UpdateOrganization")]
        //[HttpPut]
        //public  
    }
}
