using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GUI.Controllers
{
    [RoutePrefix("api/needy")]
    public class NeedyController : ApiController
    {
        [Route("addNeedy"), HttpPost]
        public IHttpActionResult addNeedy([FromBody]NeedyDTO needy)
        {
            var result = BL.NeedyUserBL.AddNeedyUser(needy);
            if (result)
                return Ok("ooooooooooo");
            return BadRequest();
        }
        [Route("CreateNeedyUser")]
        [HttpPost]
        public IHttpActionResult AddNeedyUser([FromBody] DTO.NeedyDTO u)
        {
            var result = BL.NeedyUserBL.AddNeedyUser(u);

            if (result)
                return Ok();
            return BadRequest();
        }
        [Route("RemoveNeedyUser")]
        [HttpDelete]
        public IHttpActionResult RemoveNeedyUser([FromBody] DTO.NeedyDTO u)
        {
            var result = BL.NeedyUserBL.RemoveNeedyUser(u);
            if (result)
                return Ok();
            return BadRequest();

        }
    }
}
