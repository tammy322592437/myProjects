using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GUI.Controllers
{
    [RoutePrefix("api/organizer")]
    public class OrganizerController : ApiController
    {
        [Route("sendMessageToAllTheVolunteers"),HttpGet]
        public IHttpActionResult sendMessageToAllTheVolunteers(int organizationKod)
        {
            var result = BL.OrganizerUserBL.sendMessageToAllTheVolunteers(organizationKod);
            if (result)
                return Ok();
            return BadRequest();
        }
        [Route("deleteRequest"), HttpPut]
        public IHttpActionResult deleteRequest(NeedyDTO needyDTO)
        {
            var result = BL.OrganizerUserBL.deleteRequest(needyDTO);
            if (result)
                return Ok();
            return BadRequest();

        }
        [Route("SignInOrganizerUser"), HttpGet]
        public OrganizerDTO SignInOrganizerUser(string name, string Password)
        {

            return BL.OrganizerUserBL.SignInOrganizerUser(name, Password);
        }

        [Route("updateRequsts")]
        [HttpPut]
        public IHttpActionResult updateRequsts([FromBody] NeedyDTO update)
        {
            var f = BL.OrganizerUserBL.updateRequsts(update);
            if (f)
                return Ok();
            return BadRequest();
        }
        [Route("getRequestsForSupport"), HttpGet]
        public List<DTO.NeedyDTO> getRequestsForSupport(int organizationKod)
        {
            var q = BL.OrganizerUserBL.getRequestsForSupport(organizationKod);
            return q;
        }

        [Route("getNeedyDetails"), HttpGet]
        public List<DTO.NeedyDTO> getNeedyDetails(int organizationKod)
        {
            return BL.OrganizerUserBL.getNeedyDetails(organizationKod);
        }

        [Route("getRequests"), HttpGet]
        public List<DTO.Selected_Menu_For_Help> getRequests(int organizationKod)
        {

            return BL.OrganizerUserBL.getRequests(organizationKod);
        }
        [Route("CreateOrganizerUser")]
        [HttpPost]
        public IHttpActionResult AddOrganizerUser([FromBody] DTO.OrganizerDTO o)
        {
            var result = BL.OrganizerUserBL.AddOrganizerUser(o);
            if (result)
                return Ok();
            return BadRequest();

        }

        [Route("RemoveOrganizerUser")]
        [HttpDelete]
        public IHttpActionResult RemoveOrganizerUser([FromBody] DTO.OrganizerDTO o)
        {
            var result = BL.OrganizerUserBL.RemoveOrganizerUser(o);
            if (result)
                return Ok();
            return BadRequest();

        }
        [Route("GetOrganizerUser")]
        [HttpGet]
        public List<DTO.OrganizerDTO> GetOrganizer()
        {
            return BL.OrganizerUserBL.GetOrganizer();
        }
    }
}
