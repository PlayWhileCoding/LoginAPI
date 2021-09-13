using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DataParkingAPI.Controllers
{
    public class ExternalLoginController : ApiController
    {
        ParkingEntities dataAccess = new ParkingEntities();

        // GET: ExternalLogin
        [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
        [HttpPost]
        [Route("api/ExternalLogin")]
        public IHttpActionResult ValidateData([FromBody]Models.UserModel loginData)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response.Headers.Add("Found", "true");
            response.Headers.Add("EmployeeID", "1");

            return Json(response, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
            });


            //var UserFound = dataAccess.SystemUsers.FirstOrDefault(m => m.LoginUserName == loginData.userName);

            //if(UserFound != null)
            //{
            //    var dataMatch = dataAccess.SystemUsers.FirstOrDefault(m => m.LoginPassword == loginData.password);
            //    if(dataMatch != null)
            //    {
            //        response.Headers.Add("Found", "true");
            //        response.Headers.Add("EmployeeID", dataMatch.Employee.ToString());
            //        return response;
            //    }
            //    else
            //    {
            //        response.Headers.Add("Found", "false");
            //        response.Headers.Add("WrongPassword","");
            //        return response;
            //    }
            //}
            //else
            //{
            //    response.Headers.Add("Found", "false");
            //    response.Headers.Add("UserNotFound", "true");
            //    return response;
            //}
                
        }
    }
}