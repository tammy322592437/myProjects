using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GUI.Controllers
{
    [RoutePrefix("api/volunteer")]
    public class VolunteerController : ApiController
    {
        [Route("logOut"),HttpGet]
        public IHttpActionResult logOut(int userKod)
        {
            var result = BL.VolunteerUserBL.logOut(userKod);
            if (result!=null)
                return Ok();
            return BadRequest();

        }
        [Route("takeSupport"), HttpPost]
        public IHttpActionResult takeSupport(DTO.Selected_Menu_For_Help s)
        {
            var result = BL.VolunteerUserBL.takeSupport(s);
            if (result)
                return Ok();
            return BadRequest();
        }
        [Route("CreateVolunteerUser")]
        [HttpPost]
        public IHttpActionResult AddVolunteerUser([FromBody] DTO.VolunteerDTO v)
        {
            var result = BL.VolunteerUserBL.AddVolunteerUser(v);
            if (result)

                return Ok();
            return BadRequest();

        }
        [Route("RemoveVolunteerUser")]
        [HttpDelete]
        public IHttpActionResult RemoveVolunteerUser([FromBody] DTO.VolunteerDTO v)
        {
            var result = BL.VolunteerUserBL.RemoveVolunteerUser(v);

            if (result)

                return Ok();
            return BadRequest();

        }
    }
}
