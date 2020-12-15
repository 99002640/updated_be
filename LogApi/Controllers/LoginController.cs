using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using LogApi.Models;
using System.Web.Http.Results;
using Newtonsoft.JsonResult;
using Newtonsoft.Json;
using LogApi.VM;
using System.IO;
using System.Net.Http.Json;

namespace LogApi.Controllers
{

    [RoutePrefix("Api/log")]

    public class LoginController : ApiController

    {

        [Route("token")]

        //[HttpGet]
        [HttpPost]

        ///
            

        public async Task<HttpResponseMessage> Load(log lg)
        {


            string url = "https://adopteriotwebapi.eaton.com/api/v1/security/token";



            using (var client = new HttpClient())
            {



                // client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // HttpResponseMessage response = await client.PostAsJsonAsync(url, lg);
                HttpResponseMessage response = await client.PostAsJsonAsync(url, new { user = lg.user, password = lg.password, applicationId = lg.applicationId });

                HttpResponseMessage msg = new HttpResponseMessage();
                msg.Content = new StringContent("fail");



                if (response.IsSuccessStatusCode)
                {

                    return response;
                }
                else
                    msg.StatusCode = HttpStatusCode.Unauthorized;

                //return msg ;


                return new HttpResponseMessage(HttpStatusCode.Unauthorized)
                {
                    ReasonPhrase = "fail"
                };

            }



        }

    }
}


    

   
    
