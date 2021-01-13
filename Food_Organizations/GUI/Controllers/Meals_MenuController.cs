using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace GUI.Controllers
{

    [RoutePrefix("api/Meals_Menu")]

    public class Meals_MenuController : ApiController
    {
        [Route("CreateMenu")]

        [HttpPost]
        public static bool AddMenu([FromBody] DTO.Meals_MenuDTO m)
        {
            return BL.Meals_Menu_BL.AddMenu(m);


        }
        [Route("UpdateeMenu")]
        [HttpPut]
        public bool UpdateMenu([FromBody] DTO.Meals_MenuDTO m)
        {

            return BL.Meals_Menu_BL.UpdateMenu(m);

        }
        [Route("RemoveItem")]
        [HttpDelete]
        
        public HttpRequestMessage RemoveItem([FromBody] DTO.Meals_MenuDTO m)
        {
            var a = new HttpRequestMessage();

            if ( BL.Meals_Menu_BL.RemoveItem(m))
            {
                
                //set the content somehow so that httpRequestMessage.Content.ReadAsStringAsync returns data 
                a.Content = new StringContent("true", Encoding.UTF8, "application/json");


                

            }
            else a.Content = new StringContent("false", Encoding.UTF8, "application/json");
            return a;
        }
        [Route("GetMenu")]
        [HttpGet]
        public  List<DTO.Meals_MenuDTO> GetMenu()
        {
           return BL.Meals_Menu_BL.GetNenu();
        }
        [Route("GetUsers")]
        [HttpGet]
        public List<DTO.Type_User> Get_Users()
        {
            return BL.Meals_Menu_BL.Get_Users();
        }
    }
}

