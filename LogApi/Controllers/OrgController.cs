using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using LogApi.VM;
//using System.Web.Mvc;

namespace LogApi.Controllers
{

    [RoutePrefix("Api/Org")]
    public class OrgController : ApiController
    {
       [Route("loc")]

       [HttpPost]
        public async Task<HttpResponseMessage> Index(Tok tk)
        {

            
            string url= "https://adopteriotwebapi.eaton.com/api/v1/useraccessprofiles/adopters/57ed4990-0fb6-4650-a069-7d62217c7b6b/users/1b2b5e77-2dc6-4b42-b96d-a055b1678526";

            using(var client=new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tk.Token);

                HttpResponseMessage res = await client.GetAsync(url);

                if (res.IsSuccessStatusCode)
                {
                    return res;
                }
                else
                    return null;
                

            }

        }
    }
}