using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
//using System.Web.Http;
//using System.Web.Mvc;
using LogApi.VM;
namespace LogApi.Controllers
{

    [RoutePrefix("Api/Loc")]
    public class SiteController : ApiController
    {

        [Route("site")]
        // GET: Site
        public async Task<HttpResponseMessage>Index(Tok tk)
        {
            string url = "https://adopteriotwebapi.eaton.com/api/v1/sites/39e41714-080d-ff7b-23ca-e79bc9437431?recursive=true";
             using(var client =new HttpClient())
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