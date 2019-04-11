using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DataParkingAPI.Controllers
{
    public class ExternalLoginController : ApiController
    {
        ParkingEntities dataAccess = new ParkingEntities();

        // GET: ExternalLogin
        [HttpPost]
        [Route("api/ExternalLogin")]
        public HttpResponseMessage ValidateData(Models.LoginModel loginData)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var UserFound = dataAccess.SystemUsers.FirstOrDefault(m => m.LoginUserName == loginData.UserName);

            if(UserFound != null)
            {
                var dataMatch = dataAccess.SystemUsers.FirstOrDefault(m => m.LoginPassword == loginData.Password);
                if(dataMatch != null)
                {
                    response.Headers.Add("Found", "true");
                    response.Headers.Add("EmployeeID", dataMatch.Employee.ToString());
                    return response;
                }
                else
                {
                    response.Headers.Add("Found", "false");
                    response.Headers.Add("WrongPassword","");
                    return response;
                }
            }
            else
            {
                response.Headers.Add("Found", "false");
                response.Headers.Add("UserNotFound", "true");
                return response;
            }
                
        }
    }
}