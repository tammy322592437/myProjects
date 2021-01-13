using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace GUI.Controllers
{

    [RoutePrefix("api/MealsMenu")]

    public class MealsMenuController : ApiController
    {
        [Route("CreateMenu")]

        [HttpPost]
        public IHttpActionResult AddMenu([FromBody] DTO.Meals_MenuDTO m)
        {
           

            var result = BL.Meals_Menu_BL.AddMenu(m);

            if (result)
                return Ok();
            return BadRequest();

        }
        [Route("UpdateeMenu")]
        [HttpPut]
        public IHttpActionResult UpdateMenu([FromBody] DTO.Meals_MenuDTO m)
        {

            var result = BL.Meals_Menu_BL.UpdateMenu(m);

            if (result)
                return Ok();
            return BadRequest();
            

        }
        [Route("RemoveItem")]
        [HttpDelete]
        
        public IHttpActionResult RemoveItem([FromBody] DTO.Meals_MenuDTO m)
        {

            var result = BL.Meals_Menu_BL.RemoveItem(m);

            if (result)
                return Ok();
            return BadRequest();
        }
        [Route("GetMenu")]
        [HttpGet]
        public  List<DTO.Meals_MenuDTO> GetMenu()
        {
           return BL.Meals_Menu_BL.GetNenu();
        }
        [Route("GetUsers")]
        [HttpGet]
        public List<DTO.Type_User> getUser()
        {
            return BL.Meals_Menu_BL.getUser();
        }
        
    }
}

